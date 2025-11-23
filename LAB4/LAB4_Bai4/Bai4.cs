using System.Net;
using System.Linq;
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace LAB4_Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }


        private string getHTML(string szURL = "https://betacinemas.vn/phim.htm")
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }


        public class Movie
        {
            public string TenPhim { get; set; }
            public string LinkPhim { get; set; }
            public string LinkAnh { get; set; }
        }
        private List<Movie> LayThongTinPhim(string html)
        {
            List<Movie> movies = new List<Movie>();
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html);
            var imgNodes = htmlDoc.DocumentNode.SelectNodes("//img[contains(@class,'img-responsive border-radius-20')]");
            var titleNodes = htmlDoc.DocumentNode.SelectNodes("//h3[contains(@class,'text-center') and contains(@class,'margin-top-5')]");
            if (imgNodes == null || titleNodes == null)
                return movies;
            int count = Math.Min(imgNodes.Count, titleNodes.Count);

            Pb_process.Maximum = count*2;
            Pb_process.Minimum = 0;
            Pb_process.Value = 0;

            for (int i = 0; i < count; i++)
            {
                var imgNode = imgNodes[i];
                var titleNode = titleNodes[i];
                var linkNode = titleNode.SelectSingleNode(".//a");
                if (imgNode != null && titleNode != null && linkNode != null)
                {
                    Movie movie = new Movie
                    {
                        TenPhim = titleNode.InnerText.Trim(),
                        LinkAnh = imgNode.GetAttributeValue("src", ""),
                        LinkPhim = linkNode.GetAttributeValue("href", "")
                    };
                    movies.Add(movie);
                }
                Pb_process.Value = i + 1;
            }
            return movies;
        }

        private Control TaoThePhim(Movie mv, WebClient client)
        {
            Panel panel = new Panel
            {
                Width = 1171,
                Height = 80,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10, 5, 10, 5),
                Tag = mv
            };
            PictureBox pictureBox = new PictureBox
            {
                Width = 60,
                Height = 70,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = 5,
                Top = 5,
                Tag = mv
            };
            Label title = new Label
            {
                Text = mv.TenPhim,
                AutoSize = false,
                Left = pictureBox.Right + 10,
                Top = 5,
                Width = panel.Width - pictureBox.Width - 25,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.OrangeRed,
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                Tag = mv
            };
            Label link = new Label
            {
                Text = "https://betacinemas.vn" + mv.LinkPhim,
                AutoSize = false,
                Left = pictureBox.Right + 10,
                Top = 35,
                Width = panel.Width - pictureBox.Width - 25,
                Height = 20,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Tag = mv
            };
            try
            {
                byte[] data = client.DownloadData(mv.LinkAnh);
                using (var ms = new MemoryStream(data))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            catch
            {
            }
            panel.Click += BamVaoLink;
            pictureBox.Click += BamVaoLink;
            title.Click += BamVaoLink;
            link.Click += BamVaoLink;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(title);
            panel.Controls.Add(link);
            return panel;
        }

        private void BamVaoLink(object? sender, EventArgs e)
        {
            var ctrl = sender as Control;
            var mv = ctrl?.Tag as Movie;
            if (mv == null) return;

            string url = mv.LinkPhim;
            if (url.StartsWith("/"))
                url = "https://betacinemas.vn" + url;

            InfoPhim.LinkMovie = url;
            InfoPhim infoPhim = new InfoPhim();
            infoPhim.Show();
        }

        private void HienThiDanhSachPhim(List<Movie> movies)
        {
            using (var client = new WebClient())
            {
                foreach (var mv in movies)
                {
                    var card = TaoThePhim(mv, client);
                    fLP_main.Controls.Add(card);

                    Pb_process.Value += 1;
                }
            }
        }
        private async void Bai4_Load(object sender, EventArgs e)
        {

            string DataWebsite = getHTML();
            var movies = LayThongTinPhim(DataWebsite);
            HienThiDanhSachPhim(movies);
        }

        private void Pb_process_Click(object sender, EventArgs e)
        {

        }
    }
}
