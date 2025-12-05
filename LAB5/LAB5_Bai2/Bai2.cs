using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace LAB5_Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            SetupListView();
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("From", 150);
            listView1.Columns.Add("Thời gian", 150);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Password!");
                return;
            }

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    label3.Text = "Total: " + inbox.Count.ToString();
                    label4.Text = "Recent: " + inbox.Recent.ToString();

                    listView1.Items.Clear();

                    if (inbox.Count > 0)
                    {
                        int limit = 50;
                        int startIndex = Math.Max(0, inbox.Count - limit);

                        var items = inbox.Fetch(startIndex, -1, MessageSummaryItems.Envelope);

                        for (int i = items.Count - 1; i >= 0; i--)
                        {
                            var item = items[i];

                            ListViewItem lvItem = new ListViewItem(item.Envelope.Subject ?? "(No Subject)");
                            lvItem.SubItems.Add(item.Envelope.From.ToString());

                            string dateStr = item.Envelope.Date.HasValue
                                ? item.Envelope.Date.Value.ToString("dd/MM/yyyy HH:mm:ss")
                                : "";
                            lvItem.SubItems.Add(dateStr);

                            listView1.Items.Add(lvItem);
                        }
                    }

                    client.Disconnect(true);
                }

                MessageBox.Show("Đăng nhập và lấy mail thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message + "\n\n(Lưu ý: Nếu dùng Gmail hãy chắc chắn bạn đang dùng App Password)");
            }
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            tb_email.Text = "24520262@gm.uit.edu.vn";
            tb_password.Text = "ytbr kjiv ighn cxni";
        }
    }
}