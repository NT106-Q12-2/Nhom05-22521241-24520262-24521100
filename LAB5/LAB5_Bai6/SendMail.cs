using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace LAB5_Bai6
{
    public partial class SendMail : Form
    {
        private string attachmentPaths;
        private string senderEmail;
        private string senderPassword;

        public SendMail(string senderEmail, string senderPassword)
        {
            InitializeComponent();
            this.senderPassword = senderPassword;
            this.senderEmail = senderEmail;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.Multiselect = false; // Chỉ chọn 1 file
                openFileDialog.Title = "Chọn tệp đính kèm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachmentPaths = openFileDialog.FileName;
                    tb_attachment.Text = System.IO.Path.GetFileName(attachmentPaths);
                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_to.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email người nhận!");
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_subject.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề email!");
                return;
            }

            try
            {
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(senderEmail));
                message.To.Add(MailboxAddress.Parse(tb_to.Text.Trim()));
                message.Subject = tb_subject.Text.Trim();

                var builder = new BodyBuilder();

                if (checkBox_HTML.Checked)
                {
                    builder.HtmlBody = tb_body.Text;
                }
                else
                {
                    builder.TextBody = tb_body.Text;
                }

                if (!string.IsNullOrEmpty(attachmentPaths) && System.IO.File.Exists(attachmentPaths))
                {
                    builder.Attachments.Add(attachmentPaths);
                }

                message.Body = builder.ToMessageBody();

                using (var smtpClient = new SmtpClient())
                {
                    // Port 465 phải dùng SslOnConnect
                    smtpClient.Connect("smtp.gmail.com", 465, true);

                    smtpClient.Authenticate(senderEmail, senderPassword);

                    smtpClient.Send(message);
                    smtpClient.Disconnect(true);
                }

                MessageBox.Show("Gửi email thành công!");

                tb_to.Clear();
                tb_subject.Clear();
                tb_body.Clear();
                tb_attachment.Clear();
                attachmentPaths = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
            }
        }
    }
}