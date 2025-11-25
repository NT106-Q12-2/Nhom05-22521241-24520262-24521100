using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace LAB4_Bai6
{
    public partial class Bai6 : Form
    {
        private readonly HttpClient client = new HttpClient();
        private string accessToken = string.Empty;
        private string tokenType = string.Empty;
        public Bai6()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://nt106.uitiot.vn/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập username và password!");
                return;
            }

            try
            {
                var formData = new MultipartFormDataContent();
                formData.Add(new StringContent(username), "username");
                formData.Add(new StringContent(password), "password");

                HttpResponseMessage response = await client.PostAsync("auth/token", formData);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                var jobj = JObject.Parse(jsonResponse);

                if (!response.IsSuccessStatusCode)
                {
                    string detail = jobj["detail"]?.ToString() ?? "Đăng nhập thất bại";
                    lblResult.Text = $"Lỗi: {detail}";
                    return;
                }

                accessToken = jobj["access_token"]?.ToString();
                tokenType = jobj["token_type"]?.ToString() ?? "Bearer";

                lblResult.Text = $"{tokenType} {accessToken}\r\nĐăng nhập thành công!\r\nĐang lấy thông tin user...";

                await GetCurrentUserInfo();
            }
            catch (Exception ex)
            {
                lblResult.Text = "Lỗi kết nối: " + ex.Message;
            }
        }

        private async Task GetCurrentUserInfo()
        {
            try
            {
                client.DefaultRequestHeaders.Authorization
                    = new AuthenticationHeaderValue(tokenType, accessToken);

                HttpResponseMessage response = await client.GetAsync("api/v1/user/me");
                string json = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var user = JObject.Parse(json);
                    string info = $"Họ tên: {user["full_name"]}\r\n" +
                                  $"Email: {user["email"]}\r\n" +
                                  $"Phone: {user["phone"]}\r\n" +
                                  $"Role: {user["role"]}\r\n" +
                                  $"Username: {user["username"]}\r\n" +
                                  $"ID: {user["id"]}";

                    lblResult.Text += "\r\n\r\n=== THÔNG TIN USER ===\r\n" + info;
                }
                else
                {
                    var err = JObject.Parse(json);
                    lblResult.Text += $"\r\nLỗi: {err["detail"]}";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text += "\r\nLỗi: " + ex.Message;
            }
        }
    }
}