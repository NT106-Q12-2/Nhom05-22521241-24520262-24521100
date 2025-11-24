using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace LAB4_Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            txtb_url.Text = "https://nt106.uitiot.vn/auth/token";
            txtb_password.PasswordChar = '*';
        }
        private async void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtb_url.Text;
                string username = txtb_username.Text;
                string password = txtb_password.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Username và Password!");
                    return;
                }

                using (HttpClient client = new HttpClient())
                {
                    // Tạo nội dung gửi đi dạng Form-Data (MultipaartFormDataContent)
                    MultipartFormDataContent content = new MultipartFormDataContent();
                    content.Add(new StringContent(username), "username");
                    content.Add(new StringContent(password), "password");

                    // Hiển thị thông báo đang xử lý
                    rtb_content.Text = "Đang gửi yêu cầu đăng nhập...";
                    // Gửi yêu cầu POST (sử dụng await để không đơ giao diện)
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    // Đọc nội dung phản hồi từ Server
                    string responseString = await response.Content.ReadAsStringAsync();
                    // Phân tích chuỗi JSON trả về thành đối tượng JObject
                    JObject jsonResponse = JObject.Parse(responseString);

                    if (response.IsSuccessStatusCode)
                    {
                        string tokenType = jsonResponse["token_type"].ToString();
                        string accessToken = jsonResponse["access_token"].ToString();

                        rtb_content.Text = "ĐĂNG NHẬP THÀNH CÔNG!\n\n";
                        rtb_content.Text += $"Token Type: {tokenType}\n";
                        rtb_content.Text += $"Access Token: {accessToken}\n";

                        MessageBox.Show("Đăng nhập thành công!");
                    }
                    else
                    {
                        string detail = jsonResponse["detail"]?.ToString() ?? "Lỗi không xác định";
                        rtb_content.Text = "ĐĂNG NHẬP THẤT BẠI.\n\n";
                        rtb_content.Text += responseString;
                        MessageBox.Show("Đăng nhập thất bại: " + detail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                rtb_content.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}
