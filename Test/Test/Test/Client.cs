using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class Form1 : Form
    {
        private DataTable dataTable = new();
        private List<string> CacMonAn;
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 8080;
        static ASCIIEncoding encoding = new ASCIIEncoding();
        private TcpClient client = new TcpClient();
        private Stream stream;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            // 1. connect
            client.Connect("127.0.0.1", PORT_NUMBER);
            stream = client.GetStream();

            Console.WriteLine("Connected to Y2Server.");

            // 2. send
            byte[] data = encoding.GetBytes("MENU");
            stream.Write(data, 0, data.Length);
            while (CacMonAn == null)
            {
                // 3. receive
                data = new byte[BUFFER_SIZE];
                stream.Read(data, 0, BUFFER_SIZE);

                CacMonAn = encoding.GetString(data).Split(':').ToList();
            }

            foreach (string MonAn in CacMonAn)
            {

                string MonAn_id = MonAn.Split('|')[1];
                string MonAn_ten = MonAn.Split('|')[2];
                long MonAn_gia = long.Parse((MonAn.Split('|')[3]).Split('-')[0]);
                int SoLuong = 0;
                dataTable.Rows.Add(MonAn_id, MonAn_ten, MonAn_gia, 0);
                //ListViewItem lvItem = new ListViewItem(item.Envelope.Subject ?? "(No Subject)");
            }
            dataGridView1.DataSource = dataTable;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int Cot = 4;
            string orderDetails = "";
            orderDetails += "ORDER|";
            orderDetails += nud_table.Value.ToString() + "|";
            for (int Hang = 1; Hang < dataTable.Rows.Count; Hang++)
            {
                if (int.Parse(dataTable.Rows[Hang][Cot].ToString()) > 0)
                {
                    string MonAn_id = dataTable.Rows[Hang][0].ToString();
                    string SoLuong = dataTable.Rows[Hang][Cot].ToString();
                    orderDetails += MonAn_id + "|" + SoLuong + "|:";
                }
            }
            byte[] data = encoding.GetBytes(orderDetails);
            stream.Write(data, 0, data.Length);
        }

        private void nup_table_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_sv_Click(object sender, EventArgs e)
        {

        }
    }
}
