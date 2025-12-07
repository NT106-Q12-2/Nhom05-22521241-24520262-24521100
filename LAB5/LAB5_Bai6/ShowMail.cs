using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Windows.Forms;

namespace LAB5_Bai6
{
    public partial class ShowMail : Form
    {
        private MimeMessage _message;
        public ShowMail(MimeMessage message)
        {
            InitializeComponent();
            _message = message;
        }

        private void ShowMail_Load(object sender, EventArgs e)
        {
            if (_message != null)
            {
                lb_from.Text = "From: " + _message.From.ToString();
                lb_to.Text = "To: " + _message.To.ToString();
                lb_subject.Text = _message.Subject;

                string body = string.Empty;

                if (!string.IsNullOrEmpty(_message.HtmlBody))
                {
                    body = _message.HtmlBody;
                }
                else if (!string.IsNullOrEmpty(_message.TextBody))
                {
                    body = "<pre>" + _message.TextBody + "</pre>";
                }
                else
                {
                    body = "<p>Email không có nội dung</p>";
                }

                webBrowser.DocumentText = body;
            }
        }
    }
}