using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LAB4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            txtb_url.Text = "http://uit.edu.vn";
        }

        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);

            // Get the response.
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Close the response.
            response.Close();

            return responseFromServer;
        }

        // Xử lý sự kiện khi nhấn nút GET
        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtb_url.Text;
                string htmlContent = getHTML(url);
                rtb_content.Text = htmlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}