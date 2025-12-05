using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace LAB5_Bai5
{
    public partial class FormCommunity : Form
    {
        private string _userEmail;
        private string _userPassword;

        public FormCommunity(string email, string password)
        {
            InitializeComponent();
            _userEmail = email;
            _userPassword = password;

            tb_email.Text = _userEmail;
            tb_password.Text = new string('*', _userPassword.Length);
        }
        public FormCommunity()
        {
            InitializeComponent();
        }

        private void FormCommunity_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper.InitializeDatabase();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo CSDL: " + ex.Message);
            }
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_duongdanhinhanh.Text = ofd.FileName;
                ptb_hinhanhdonggop.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void btn_donggop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_monan.Text) || ptb_hinhanhdonggop.Image == null)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn và chọn hình ảnh.");
                return;
            }

            try
            {
                byte[] imgBytes = DatabaseHelper.ImageToByteArray(ptb_hinhanhdonggop.Image);
                string dishName = tb_monan.Text;
                string imagePath = tb_duongdanhinhanh.Text;

                DatabaseHelper.AddDish(dishName, imgBytes, _userEmail);

                try
                {
                    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                    {
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new NetworkCredential(_userEmail, _userPassword);

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(_userEmail);
                        mail.To.Add("24520262@gm.uit.edu.vn");
                        mail.Subject = "Đóng góp món ăn";

                        mail.Body = $"{dishName};{imagePath}";

                        smtpClient.Send(mail);
                    }
                    MessageBox.Show("Thêm món ăn và gửi email thành công!");
                }
                catch (Exception emailEx)
                {
                    MessageBox.Show("Đã lưu món ăn vào CSDL nhưng gửi email thất bại: " + emailEx.Message);
                }

                tb_monan.Clear();
                tb_duongdanhinhanh.Clear();
                ptb_hinhanhdonggop.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn (DB): " + ex.Message);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                Dish dish = DatabaseHelper.GetRandomDish();

                if (dish != null)
                {
                    rtb_thongtinmonan.Text = "";
                    rtb_thongtinmonan.AppendText($"Món ăn: {dish.Name}\n");
                    rtb_thongtinmonan.AppendText($"Đóng góp bởi: {dish.UserEmail}\n");
                    rtb_thongtinmonan.AppendText($"Thời gian: {dish.CreatedAt}\n");

                    if (dish.Image != null && dish.Image.Length > 0)
                    {
                        ptb_hinhanhmonan.Image = DatabaseHelper.ByteArrayToImage(dish.Image);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có món ăn nào trong cộng đồng. Hãy đóng góp trước!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }
    }
}