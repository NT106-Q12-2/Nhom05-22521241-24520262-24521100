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
            string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string filePath = Path.Combine(downloadFolder, "uit.html");

            txtb_url.Text = "http://uit.edu.vn";
            txtb_filepath.Text = filePath;
        }

        private void btn_dowload_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtb_url.Text;
                string filePath = txtb_filepath.Text;

                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Vui lòng nhập URL và đường dẫn lưu file!");
                    return;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                WebClient myClient = new WebClient();

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                myClient.DownloadFile(url, filePath);

                Stream response = myClient.OpenRead(url);

                StreamReader reader = new StreamReader(response);
                string content = reader.ReadToEnd();

                rtb_content.Text = content;

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
