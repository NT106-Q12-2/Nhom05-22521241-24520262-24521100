using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_Bai7
{
    public partial class frmFoods : Form
    {
        private readonly FoodClient api;
        private int currentPage = 1;
        private bool isMyFood = false;

        public frmFoods(FoodClient client)
        {
            InitializeComponent();
            api = client;
        }

        private async void frmFoods_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Chào {api.FullName}! ({api.Username})";
            await LoadFoods();
        }

        private async Task LoadFoods()
        {
            try
            {
                List<Food> foods;
                if (isMyFood)
                {
                    foods = await api.GetMyFoodsAsync(currentPage);
                }
                else
                {
                    foods = await api.GetAllFoodsAsync(currentPage);
                }

                dgvFoods.Rows.Clear();

                for (int i = 0; i < foods.Count; i++)
                {
                    int stt = (currentPage - 1) * 10 + i + 1;
                    dgvFoods.Rows.Add(stt, foods[i].ten_mon_an, foods[i].nguoi_tao, foods[i].ngay_tao, "Xóa");
                    dgvFoods.Rows[i].Tag = foods[i].id;
                }

                lblPage.Text = $"Trang {currentPage}";
                
                // Vô hiệu hóa nút Trang trước nếu đang ở trang 1
                btnPrev.Enabled = currentPage > 1;
                // Vô hiệu hóa nút Trang sau nếu không có dữ liệu
                btnNext.Enabled = foods.Count >= 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load dữ liệu:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLoadAll_Click(object sender, EventArgs e)
        {
            isMyFood = false;
            currentPage = 1;
            await LoadFoods();
        }

        private async void btnLoadMy_Click(object sender, EventArgs e)
        {
            isMyFood = true;
            currentPage = 1;
            await LoadFoods();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = await api.AddFoodAsync(name);
            if (success)
            {
                MessageBox.Show("Thêm món ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFoodName.Clear();
                
                // Tự động chuyển sang tab "Xem của tôi" và refresh
                isMyFood = true;
                currentPage = 1;
                await Task.Delay(300); // Đợi server xử lý
                await LoadFoods();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvFoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvFoods.Columns["colDelete"].Index)
            {
                var row = dgvFoods.Rows[e.RowIndex];
                string foodName = row.Cells["colName"].Value?.ToString() ?? "";
                int foodId = (int)(row.Tag ?? 0);

                var result = MessageBox.Show($"Bạn có chắc muốn xóa món '{foodName}'?", 
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool deleted = await api.DeleteFoodAsync(foodId);
                    if (deleted)
                    {
                        MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadFoods();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await LoadFoods();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            await LoadFoods();
        }

        private async void btnRandomAll_Click(object sender, EventArgs e)
        {
            var food = await api.GetRandomFoodAsync(true);
            if (food != null)
            {
                MessageBox.Show($"Hôm nay ăn: {food.ten_mon_an}", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chưa có món ăn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnRandomMy_Click(object sender, EventArgs e)
        {
            var food = await api.GetRandomFoodAsync(false);
            if (food != null)
            {
                MessageBox.Show($"Món của bạn: {food.ten_mon_an}", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa có món ăn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
