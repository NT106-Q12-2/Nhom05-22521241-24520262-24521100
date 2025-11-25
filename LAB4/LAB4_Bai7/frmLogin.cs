using System;
using System.Windows.Forms;

namespace LAB4_Bai7
{
    public partial class frmLogin : Form
    {
        private FoodClient api = new FoodClient();

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = await api.LoginAsync(user, pass);
            if (ok)
            {
                this.Hide();
                new frmFoods(api).Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}