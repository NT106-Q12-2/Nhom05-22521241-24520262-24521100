using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Test
{
    public partial class Server : Form
    {
        private TcpListener _listener;
        private bool _isListening = false;
        private int _port = 8080;

        // Dictionary lưu trữ menu: Key = Tên món, Value = Giá
        private Dictionary<string, decimal> _menuPrices = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

        // Lưu nội dung của menu để gửi cho client
        private string _rawMenuContent = "";

        private Thread _serverThread;

        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadMenu();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!_isListening)
            {
                try
                {
                    _listener = new TcpListener(IPAddress.Any, _port);
                    _listener.Start();
                    _isListening = true;

                    _serverThread = new Thread(ServerLoop);
                    _serverThread.IsBackground = true;
                    _serverThread.Start();

                    btn_start.Text = "STOP";
                    lb_status.Text = $"Listening on port {_port}";
                    AppendLog($"Server started. Listening on port {_port}...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi khởi động server: " + ex.Message);
                    AppendLog("Error starting server: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    _isListening = false;
                    _listener?.Stop();
                    // ServerThread sẽ tự kết thúc khi _listener.Stop() gây ra ngoại lệ hoặc vòng lặp kết thúc

                    btn_start.Text = "START";
                    lb_status.Text = "Stopped";
                    AppendLog("Server stopped.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi dừng server: " + ex.Message);
                    AppendLog("Error stopping server: " + ex.Message);
                }
            }
        }

        private void ServerLoop()
        {
            try
            {
                while (_isListening)
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    AppendLog("New client connected.");

                    Thread clientThread = new Thread(HandleClient);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (SocketException)
            {
            }
            catch (Exception ex)
            {
                AppendLog("Server loop error: " + ex.Message);
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();

            try
            {
                if (!string.IsNullOrEmpty(_rawMenuContent))
                {
                    byte[] menuBytes = Encoding.UTF8.GetBytes(_rawMenuContent);
                    stream.Write(menuBytes, 0, menuBytes.Length);
                    AppendLog("Sent menu to client.");
                }

                // Lắng nghe order từ Client
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AppendLog($"Received: {message}");

                    // Xử lý chuỗi (Format: Table;Dish;Quantity)
                    ProcessClientOrder(message);
                }
            }
            catch (Exception ex)
            {
                AppendLog("Client error: " + ex.Message);
            }
            finally
            {
                client.Close();
                AppendLog("Client disconnected.");
            }
        }

        // Xử lý chuỗi dữ liệu nhận được và cập nhật lên Grid
        private void ProcessClientOrder(string message)
        {
            var parts = message.Split(';');
            if (parts.Length < 3)
            {
                AppendLog("Invalid format received.");
                return;
            }

            string table = parts[0].Trim();
            string dishName = parts[1].Trim();
            string quantityStr = parts[2].Trim();

            if (int.TryParse(quantityStr, out int quantity))
            {
                decimal price = 0;
                string standardName = dishName;

                var keyFound = _menuPrices.Keys.FirstOrDefault(k => k.Equals(dishName, StringComparison.OrdinalIgnoreCase));
                if (keyFound == null)
                {
                    keyFound = _menuPrices.Keys.FirstOrDefault(k => k.IndexOf(dishName, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                if (keyFound != null)
                {
                    price = _menuPrices[keyFound];
                    standardName = keyFound;

                    decimal total = price * quantity;

                    if (dgv_thongke.InvokeRequired)
                    {
                        dgv_thongke.Invoke(new Action(() =>
                        {
                            dgv_thongke.Rows.Add(table, standardName, price, quantity, total);
                        }));
                    }
                    else
                    {
                        dgv_thongke.Rows.Add(table, standardName, price, quantity, total);
                    }

                    AppendLog($"Order processed: {table} - {standardName} x{quantity}");
                }
                else
                {
                    AppendLog($"Dish not found in menu: {dishName}");
                }
            }
        }

        private void AppendLog(string text)
        {
            if (rtb_log.InvokeRequired)
            {
                rtb_log.Invoke(new Action(() =>
                {
                    rtb_log.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}{Environment.NewLine}");
                }));
            }
            else
            {
                rtb_log.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}{Environment.NewLine}");
            }
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
        }

        private void SetupDataGridView()
        {
            dgv_thongke.Columns.Clear();

            dgv_thongke.Columns.Add("colTable", "Số bàn");
            dgv_thongke.Columns.Add("colDish", "Món ăn");
            dgv_thongke.Columns.Add("colUnitPrice", "Đơn giá");
            dgv_thongke.Columns.Add("colQuantity", "Số lượng");
            dgv_thongke.Columns.Add("colTotal", "Thành tiền");

            dgv_thongke.Columns[2].ValueType = typeof(decimal);
            dgv_thongke.Columns[3].ValueType = typeof(int);
            dgv_thongke.Columns[4].ValueType = typeof(decimal);

            dgv_thongke.Columns[2].DefaultCellStyle.Format = "N0";
            dgv_thongke.Columns[4].DefaultCellStyle.Format = "N0";

            dgv_thongke.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_thongke.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_thongke.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void LoadMenu()
        {
            try
            {
                string path = "menu.txt";

                if (!File.Exists(path))
                {
                    MessageBox.Show("File menu.txt không tồn tại! Vui lòng tạo file tại thư mục bin/Debug.");
                    return;
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    _rawMenuContent = sr.ReadToEnd();

                    var lines = _rawMenuContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(';');

                        if (parts.Length >= 3)
                        {
                            var name = parts[1].Trim();
                            var priceStr = parts[2].Trim();

                            if (decimal.TryParse(priceStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price))
                            {
                                if (!_menuPrices.ContainsKey(name))
                                {
                                    _menuPrices.Add(name, price);
                                }
                            }
                        }
                    }
                }

                lb_status.Text = $"Đã tải {_menuPrices.Count} món ăn. Sẵn sàng phục vụ.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file menu: " + ex.Message);
            }
        }
    }
}