using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LAB4_Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();

            // Cách này đảm bảo lưu được trên ổ C mà không bị lỗi quyền Admin
            string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string filePath = Path.Combine(downloadFolder, "uit.html");

            // Gán giá trị mặc định
            txtb_url.Text = "http://uit.edu.vn";
            txtb_filepath.Text = filePath; // Hiển thị đường dẫn an toàn lên textbox
        }

        private void btn_dowload_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtb_url.Text;
                string filePath = txtb_filepath.Text;

                // Kiểm tra nếu chưa nhập đường dẫn
                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Vui lòng nhập URL và đường dẫn lưu file!");
                    return;
                }

                // Sửa lỗi bảo mật SSL/TLS cho các trang web https (như uit.edu.vn)
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Khởi tạo WebClient
                WebClient myClient = new WebClient();

                // Nếu file đã tồn tại thì xóa đi để tải file mới, tránh lỗi file đang được sử dụng
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Tải file về máy (DownloadFile)
                myClient.DownloadFile(url, filePath);

                // Đọc nội dung để hiển thị lên màn hình (OpenRead)
                Stream response = myClient.OpenRead(url);

                // Đọc dữ liệu từ Stream
                StreamReader reader = new StreamReader(response);
                string content = reader.ReadToEnd();

                // Hiển thị ra RichTextBox
                rtb_content.Text = content;

                // Đóng Stream lại sau khi dùng xong
                response.Close();

                MessageBox.Show("Đã tải về và lưu file thành công tại:\n" + filePath);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\nChi tiết: " + ex.InnerException.Message;
                }
                MessageBox.Show("Lỗi: " + message);
            }
        }
    }
}