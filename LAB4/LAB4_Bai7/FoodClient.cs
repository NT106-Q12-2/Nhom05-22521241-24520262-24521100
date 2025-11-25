using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LAB4_Bai7
{
    public class FoodClient
    {
        private readonly HttpClient client;
        public string AccessToken { get; private set; } = string.Empty;
        public string FullName { get; private set; } = string.Empty;
        public string Username { get; private set; } = string.Empty;

        public FoodClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://nt106.uitiot.vn/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            try
            {
                var form = new MultipartFormDataContent();
                form.Add(new StringContent(username), "username");
                form.Add(new StringContent(password), "password");

                var response = await client.PostAsync("auth/token", form);
                if (!response.IsSuccessStatusCode) return false;

                var json = await response.Content.ReadAsStringAsync();
                var obj = JObject.Parse(json);
                AccessToken = obj["access_token"]?.ToString() ?? string.Empty;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var userResp = await client.GetAsync("api/v1/user/me");
                if (userResp.IsSuccessStatusCode)
                {
                    var userJson = await userResp.Content.ReadAsStringAsync();
                    var user = JObject.Parse(userJson);
                    FullName = user["full_name"]?.ToString() ?? "Người dùng";
                    Username = user["username"]?.ToString() ?? username;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> AddFoodAsync(string name)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                var payload = new
                {
                    ten_mon_an = name.Trim(),
                    gia = 50000,
                    mo_ta = "string",
                    hinh_anh = "string",
                    dia_chi = "string",
                    nguoi_tao = "string"
                };

                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("api/v1/monan/add", content);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Food>> GetAllFoodsAsync(int page = 1)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                // Thử dùng query parameters thay vì POST body
                var response = await client.GetAsync($"api/v1/monan/all?page={page}&page_size=10");
                
                if (!response.IsSuccessStatusCode)
                {
                    // Nếu GET không work, thử POST
                    var payload = new { page, page_size = 10 };
                    var json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    response = await client.PostAsync("api/v1/monan/all", content);
                    
                    if (!response.IsSuccessStatusCode) return new List<Food>();
                }

                var result = await response.Content.ReadAsStringAsync();
                var obj = JObject.Parse(result);
                var dataJson = obj["data"]?.ToString() ?? "[]";
                return JsonConvert.DeserializeObject<List<Food>>(dataJson) ?? new List<Food>();
            }
            catch
            {
                return new List<Food>();
            }
        }

        public async Task<List<Food>> GetMyFoodsAsync(int page = 1)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

                // Thử dùng query parameters thay vì POST body
                var response = await client.GetAsync($"api/v1/monan/my-dishes?page={page}&page_size=10");
                
                if (!response.IsSuccessStatusCode)
                {
                    // Nếu GET không work, thử POST
                    var payload = new { page, page_size = 10 };
                    var json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    response = await client.PostAsync("api/v1/monan/my-dishes", content);
                    
                    if (!response.IsSuccessStatusCode) return new List<Food>();
                }
                
                var result = await response.Content.ReadAsStringAsync();
                var obj = JObject.Parse(result);
                var dataJson = obj["data"]?.ToString() ?? "[]";
                var foods = JsonConvert.DeserializeObject<List<Food>>(dataJson) ?? new List<Food>();
                
                return foods;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"GetMyFoods Error: {ex.Message}", "Error");
                return new List<Food>();
            }
        }

        public async Task<bool> DeleteFoodAsync(int id)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                var response = await client.DeleteAsync($"api/v1/monan/{id}");
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Food?> GetRandomFoodAsync(bool fromAll = true)
        {
            try
            {
                var list = fromAll ? await GetAllFoodsAsync(1) : await GetMyFoodsAsync(1);
                if (list.Count == 0) return null;
                return list[new Random().Next(list.Count)];
            }
            catch
            {
                return null;
            }
        }
    }
}
