using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_Bai4
{
    public partial class InfoPhim : Form
    {
        public InfoPhim()
        {
            InitializeComponent();
            this.webView.Dock = DockStyle.Fill;
            this.webView.Source = new Uri(LinkMovie);
        }

        public static string LinkMovie = "";

        private void InfoPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
