using System.Net;
using System.Net.Mail;

namespace lab5_cau4
{
    public class EmailService
    {
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string SenderEmail = "sonvskt303@gmail.com";
        private const string SenderPassword = "pdbseatnxnayhvfa"; // App Password (spaces removed)

        public static bool SendTicketConfirmation(string recipientEmail, string customerName, string movieName, List<int> seatNumbers, string slogan, string posterPath)
        {
            try
            {
                // Tạo nội dung email HTML
                string seatList = string.Join(", ", seatNumbers);
                string emailBody = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif;'>
                        <h2 style='color: #2c3e50;'>Xác nhận đặt vé xem phim</h2>
                        <p>Kính gửi <strong>{customerName}</strong>,</p>
                        <p>Cảm ơn bạn đã đặt vé xem phim tại rạp của chúng tôi.</p>
                        
                        <div style='background-color: #f8f9fa; padding: 20px; border-radius: 5px; margin: 20px 0;'>
                            <h3 style='color: #495057;'>Thông tin vé:</h3>
                            <p><strong>Tên phim:</strong> {movieName}</p>
                            <p><strong>Số ghế:</strong> {seatList}</p>
                            <p><strong>Slogan:</strong> {slogan}</p>
                        </div>
                        
                        {(File.Exists(posterPath) ? $"<img src='cid:poster' style='max-width: 400px; border-radius: 5px;' />" : "")}
                        
                        <p style='margin-top: 20px;'>Chúc bạn có trải nghiệm xem phim thú vị!</p>
                        <p style='color: #6c757d;'>Trân trọng,<br/>Đội ngũ Rạp chiếu phim</p>
                    </body>
                    </html>
                ";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(SenderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = $"Xác nhận đặt vé - {movieName}";
                    mail.Body = emailBody;
                    mail.IsBodyHtml = true;

                    // Đính kèm poster nếu có
                    if (File.Exists(posterPath))
                    {
                        LinkedResource poster = new LinkedResource(posterPath);
                        poster.ContentId = "poster";
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(emailBody, null, "text/html");
                        htmlView.LinkedResources.Add(poster);
                        mail.AlternateViews.Add(htmlView);
                    }

                    using (SmtpClient smtp = new SmtpClient(SmtpServer, SmtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(SenderEmail, SenderPassword);
                        smtp.EnableSsl = true;
                        
                        // Nếu không có cấu hình SMTP thực, chỉ hiển thị thông báo
                        if (SenderPassword == "your_app_password_here")
                        {
                            MessageBox.Show(
                                $"Email sẽ được gửi đến: {recipientEmail}\n\n" +
                                $"Khách hàng: {customerName}\n" +
                                $"Phim: {movieName}\n" +
                                $"Số ghế: {seatList}\n" +
                                $"Slogan: {slogan}\n\n" +
                                $"(Để gửi email thực, vui lòng cấu hình SMTP trong EmailService.cs)",
                                "Xác nhận đặt vé",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            return true;
                        }
                        else
                        {
                            smtp.Send(mail);
                            MessageBox.Show("Email xác nhận đã được gửi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
