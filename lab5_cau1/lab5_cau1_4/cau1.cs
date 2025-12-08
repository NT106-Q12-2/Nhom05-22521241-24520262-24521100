using System;
using System.Windows.Forms;
// Hai thư viện này cần thiết để chạy đoạn code gợi ý trong ảnh
using MailKit.Net.Smtp;
using MimeKit;
namespace lab5_cau1_4
{
    public partial class cau1 : Form
    {
        public cau1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Tạo đối tượng SmtpClient (Lưu ý: đây là của MailKit, không phải System.Net.Mail)
                var client = new SmtpClient();

                // 2. Kết nối đến Server (Theo gợi ý: SMTPHost, SMTPPort, true)
                // Host của Gmail là smtp.gmail.com, Port SSL là 465
                client.Connect("smtp.gmail.com", 465, true);

                // 3. Xác thực (Theo gợi ý: username, password)
                // Vì giao diện mẫu không có ô Password, bạn điền trực tiếp App Password của bạn vào đây
                string username = txtFrom.Text;
                string password = "pdbs eatn xnay hvfa";

                client.Authenticate(username, password);

                // 4. Tạo nội dung Email (Theo gợi ý: MimeMessage)
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Your Name", txtFrom.Text)); // name, from
                message.To.Add(new MailboxAddress("", txtTo.Text));              // "", to
                message.Subject = txtSubject.Text;                               // subject

                // 5. Phần Body (Theo gợi ý: TextPart("plain"))
                message.Body = new TextPart("plain")
                {
                    Text = rtbBody.Text // body lấy từ RichTextBox
                };

                // 6. Gửi thư
                client.Send(message);

                // Ngắt kết nối cho sạch
                client.Disconnect(true);

                MessageBox.Show("Sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
