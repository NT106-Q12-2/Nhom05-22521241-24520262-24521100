using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private DataTable _dataTable = new DataTable();
        private const int PORT_NUMBER = 8080;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            btn_order.Enabled = false;
        }

        private void SetupDataGridView()
        {
            _dataTable.Columns.Add("ID", typeof(string));
            _dataTable.Columns.Add("Tên Món", typeof(string));
            _dataTable.Columns.Add("Đơn Giá", typeof(decimal));
            _dataTable.Columns.Add("Số Lượng", typeof(int));

            _dataTable.Columns["Số Lượng"].DefaultValue = 0;

            dataGridView1.DataSource = _dataTable;

            dataGridView1.Columns["ID"].Width = 50;
            dataGridView1.Columns["ID"].ReadOnly = true;
            dataGridView1.Columns["Tên Món"].Width = 200;
            dataGridView1.Columns["Tên Món"].ReadOnly = true;
            dataGridView1.Columns["Đơn Giá"].ReadOnly = true;
            dataGridView1.Columns["Đơn Giá"].DefaultCellStyle.Format = "N0";

            dataGridView1.Columns["Số Lượng"].ReadOnly = false;
            dataGridView1.Columns["Số Lượng"].DefaultCellStyle.BackColor = Color.LightYellow;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                _client = new TcpClient();
                _client.Connect("127.0.0.1", PORT_NUMBER);
                _stream = _client.GetStream();

                MessageBox.Show("Kết nối thành công! Đang tải menu...", "Thông báo");

                byte[] buffer = new byte[4096];
                int bytesRead = _stream.Read(buffer, 0, buffer.Length);

                if (bytesRead > 0)
                {
                    string menuData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    ParseMenuToGrid(menuData);
                }
                btn_connect.Enabled = false;
                btn_order.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void ParseMenuToGrid(string rawMenu)
        {
            _dataTable.Rows.Clear();

            string[] lines = rawMenu.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length >= 3)
                {
                    string id = parts[0];
                    string name = parts[1];
                    decimal price = 0;
                    decimal.TryParse(parts[2], out price);

                    _dataTable.Rows.Add(id, name, price, 0);
                }
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (_client == null || !_client.Connected)
            {
                MessageBox.Show("Chưa kết nối tới Server!");
                return;
            }

            string tableNumber = "Table " + nud_table.Value.ToString();
            int itemsOrdered = 0;

            try
            {
                foreach (DataRow row in _dataTable.Rows)
                {
                    int quantity = Convert.ToInt32(row["Số Lượng"]);

                    if (quantity > 0)
                    {
                        string dishId = row["ID"].ToString();

                        string message = $"{tableNumber};{dishId};{quantity}";

                        byte[] data = Encoding.UTF8.GetBytes(message);
                        _stream.Write(data, 0, data.Length);



                        itemsOrdered++;

                        row["Số Lượng"] = 0;
                    }
                }

                if (itemsOrdered > 0)
                {
                    MessageBox.Show($"Đã gửi gọi món cho {itemsOrdered} loại món ăn!", "Thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng món ăn lớn hơn 0.", "Chú ý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi order: " + ex.Message);
            }
        }
    }
}