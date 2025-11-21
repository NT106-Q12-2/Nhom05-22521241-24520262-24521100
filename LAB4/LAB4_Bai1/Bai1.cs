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
            WebRequest request = WebRequest.Create(szURL);

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            response.Close();

            return responseFromServer;
        }

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
