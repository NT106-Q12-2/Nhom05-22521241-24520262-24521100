using MailKit;
using MimeKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Security;
using System;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB5_Bai6
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            SetupListView();
            listView.DoubleClick += ListView_DoubleClick;
        }
        private void SetupListView()
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;

            listView.Columns.Add("#", 50);
            listView.Columns.Add("From", 370);
            listView.Columns.Add("Subject", 450);
            listView.Columns.Add("Thời gian", 246);
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            btn_sendmail.Hide();
            btn_f5.Hide();
        }

        public static ImapClient client = new ImapClient();

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
                client.Connect(tb_iamp.Text, (int)nUD_iamp.Value, SecureSocketOptions.SslOnConnect);
                client.Authenticate(email, password);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                label3.Text = "Total: " + inbox.Count.ToString();
                label4.Text = "Recent: " + inbox.Recent.ToString();

                listView.Items.Clear();

                if (inbox.Count > 0)
                {
                    int limit = 100;
                    int startIndex = Math.Max(0, inbox.Count - limit);

                    var items = inbox.Fetch(startIndex, -1, MessageSummaryItems.Envelope | MessageSummaryItems.UniqueId);

                    int displayIndex = 1;

                    for (int i = items.Count - 1; i >= 0; i--)
                    {
                        var item = items[i];

                        ListViewItem lvItem = new ListViewItem(displayIndex.ToString());

                        lvItem.SubItems.Add(item.Envelope.From.ToString());

                        lvItem.SubItems.Add(item.Envelope.Subject ?? "(No Subject)");

                        string dateStr = item.Envelope.Date.HasValue
                            ? item.Envelope.Date.Value.ToString("dd/MM/yyyy HH:mm:ss")
                            : "";
                        lvItem.SubItems.Add(dateStr);
                        lvItem.Tag = item.UniqueId;

                        listView.Items.Add(lvItem);

                        displayIndex++;

                    }
                }

                MessageBox.Show("Đăng nhập và lấy mail thành công!");

                btn_f5.Show();
                btn_sendmail.Show();
                tb_iamp.Enabled = false;
                tb_smtp.Enabled = false;
                nUD_iamp.Enabled = false;
                nUD_smtp.Enabled = false;
                tb_email.Enabled = false;
                tb_password.Enabled = false;
                btn_login.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message);
            }
        }
        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem selectedItem = listView.SelectedItems[0];
                    UniqueId uid = (UniqueId)selectedItem.Tag;

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    var message = inbox.GetMessage(uid);

                    ShowMail showMailForm = new ShowMail(message);
                    showMailForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở email: " + ex.Message);
                }
            }
        }

        private void btn_sendmail_Click(object sender, EventArgs e)
        {
            SendMail sendmail = new SendMail(tb_smtp.Text.Trim(), tb_password.Text.Trim());
            this.Hide();
            sendmail.ShowDialog();
        }

        private void btn_f5_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                label3.Text = "Total: " + inbox.Count.ToString();
                label4.Text = "Recent: " + inbox.Recent.ToString();
                listView.Items.Clear();
                if (inbox.Count > 0)
                {
                    int limit = 100;
                    int startIndex = Math.Max(0, inbox.Count - limit);
                    var items = inbox.Fetch(startIndex, -1, MessageSummaryItems.Envelope | MessageSummaryItems.UniqueId);
                    int displayIndex = 1;
                    for (int i = items.Count - 1; i >= 0; i--)
                    {
                        var item = items[i];
                        ListViewItem lvItem = new ListViewItem(displayIndex.ToString());
                        lvItem.SubItems.Add(item.Envelope.From.ToString());
                        lvItem.SubItems.Add(item.Envelope.Subject ?? "(No Subject)");
                        string dateStr = item.Envelope.Date.HasValue
                            ? item.Envelope.Date.Value.ToString("dd/MM/yyyy HH:mm:ss")
                            : "";
                        lvItem.SubItems.Add(dateStr);
                        lvItem.Tag = item.UniqueId;
                        listView.Items.Add(lvItem);
                        displayIndex++;
                    }
                }
            }
        }
    }
}
