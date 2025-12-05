using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace LAB5_Bai5
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Password.");
                return;
            }

            btn_login.Enabled = false;
            btn_login.Text = "Checking...";

            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(email, password);

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(email);
                    mail.To.Add(email);
                    mail.Subject = "Login Check";
                    mail.Body = "Success";

                    smtpClient.Send(mail);
                }

                MessageBox.Show("Đăng nhập thành công!");

                FormCommunity community = new FormCommunity(email, password);
                this.Hide();
                community.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message + "\n(Lưu ý: Dùng App Password nếu là Gmail)");
            }
            finally
            {
                btn_login.Enabled = true;
                btn_login.Text = "LOGIN";
            }
        }
    }
}