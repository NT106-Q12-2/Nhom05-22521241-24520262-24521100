using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            txtb_url.Text = "http://uit.edu.vn";
            InitializeWebView();
        }

        // Hàm khởi tạo môi trường cho WebView2
        async void InitializeWebView()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        // Chức năng Load Website (Nút btn_load)
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtb_url.Text)) return;

                string url = txtb_url.Text;
                if (!url.StartsWith("http"))
                {
                    url = "http://" + url;
                    txtb_url.Text = url;
                }

                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load: " + ex.Message);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.Reload();
            }
        }

        // Chức năng Download HTML (Nút btn_downfiles)
        private void btn_downfiles_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtb_url.Text;

                // Tự động lấy thư mục Downloads để tránh lỗi Access Denied
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Lab4_HTML");
                Directory.CreateDirectory(folderPath);
                string filePath = Path.Combine(folderPath, "index.html");

                WebClient myClient = new WebClient();
                myClient.DownloadFile(url, filePath);

                MessageBox.Show("Đã tải HTML về: " + filePath);

                // Mở file lên xem (Optional)
                System.Diagnostics.Process.Start("notepad.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải HTML: " + ex.Message);
            }
        }

        // Chức năng Download Resources (Nút btn_downresources)
        private void btn_downresources_Click(object sender, EventArgs e)
        {
            try
            {
                // Sửa: txtUrl -> txtb_url
                string url = txtb_url.Text;

                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Lab4_Images");
                Directory.CreateDirectory(folderPath);

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);

                var imageNodes = document.DocumentNode.SelectNodes("//img");

                if (imageNodes == null)
                {
                    MessageBox.Show("Không tìm thấy ảnh nào trên trang này!");
                    return;
                }

                int count = 0;
                WebClient client = new WebClient();

                foreach (var node in imageNodes)
                {
                    string imgSrc = node.GetAttributeValue("src", "");

                    if (!string.IsNullOrEmpty(imgSrc))
                    {
                        Uri baseUri = new Uri(url);
                        Uri fullUri = new Uri(baseUri, imgSrc);

                        string fileName = Path.GetFileName(fullUri.LocalPath);
                        if (string.IsNullOrEmpty(fileName) || fileName.Length > 50)
                            fileName = "image_" + count + ".jpg";

                        string savePath = Path.Combine(folderPath, fileName);

                        try
                        {
                            client.DownloadFile(fullUri, savePath);
                            count++;
                        }
                        catch
                        {
                            // Bỏ qua lỗi tải ảnh lẻ
                        }
                    }
                }

                MessageBox.Show($"Đã tải xong {count} hình ảnh về thư mục:\n{folderPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải Resources: " + ex.Message);
            }
        }
    }
}