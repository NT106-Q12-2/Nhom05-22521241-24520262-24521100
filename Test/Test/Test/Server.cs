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

namespace Test
{
    public partial class Server : Form
    {
        private TcpListener _listener;
        private bool _isListening = false;
        private int _port = 8080;
        private Thread _serverThread;

        private Dictionary<string, decimal> _menuPrices = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

        private Dictionary<string, string> _menuIds = new Dictionary<string, string>();

        private string _rawMenuContent = "";

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadMenu();

            tb_table.Text = "---";
            tb_amount.Text = "0 VNĐ";
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

            dgv_thongke.CellClick += dgv_thongke_CellClick;
        }

        private void LoadMenu()
        {
            try
            {
                string path = "menu.txt";

                using (StreamReader sr = new StreamReader(path))
                {
                    _rawMenuContent = sr.ReadToEnd();
                    var lines = _rawMenuContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    _menuPrices.Clear();
                    _menuIds.Clear();

                    foreach (var line in lines)
                    {
                        var parts = line.Split(';');
                        if (parts.Length >= 3)
                        {
                            var id = parts[0].Trim();
                            var name = parts[1].Trim();
                            var priceStr = parts[2].Trim();

                            if (decimal.TryParse(priceStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price))
                            {
                                if (!_menuPrices.ContainsKey(name))
                                    _menuPrices.Add(name, price);

                                if (!_menuIds.ContainsKey(id))
                                    _menuIds.Add(id, name);
                            }
                        }
                    }
                }
                lb_status.Text = $"Đã tải {_menuPrices.Count} món. Sẵn sàng.";
                AppendLog($"Đã tải menu: {_menuPrices.Count} món.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc tệp menu: " + ex.Message);
            }
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
                    btn_start.BackColor = Color.Salmon;
                    lb_status.Text = $"Lắng nghe trên cổng {_port}";
                    AppendLog($"Server bắt đầu lắng nghe ở cổng {_port}...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khởi động: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    _isListening = false;
                    _listener?.Stop();
                    btn_start.Text = "Bắt đầu";
                    btn_start.BackColor = Control.DefaultBackColor;
                    lb_status.Text = "Dừng";
                    AppendLog("Server dừng.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi dừng server: " + ex.Message);
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
                    AppendLog("Client đã kết nối.");
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (SocketException) { }
            catch (Exception ex)
            {
                AppendLog("Server lặp thất bại: " + ex.Message);
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
                }

                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AppendLog($"Nhận: {message}");
                    ProcessClientOrder(message);
                }
            }
            catch (Exception ex)
            {
                AppendLog("Client lỗi: " + ex.Message);
            }
            finally
            {
                client.Close();
                AppendLog("Client mất kết nối.");
            }
        }

        private void ProcessClientOrder(string message)
        {
            var parts = message.Split(';');
            if (parts.Length < 3) return;

            string table = parts[0].Trim();
            string dishIdOrName = parts[1].Trim();
            string quantityStr = parts[2].Trim();

            if (int.TryParse(quantityStr, out int quantity))
            {
                string finalDishName = "";

                if (_menuIds.ContainsKey(dishIdOrName))
                {
                    finalDishName = _menuIds[dishIdOrName];
                }

                else if (_menuPrices.ContainsKey(dishIdOrName))
                {
                    finalDishName = dishIdOrName;
                }

                if (!string.IsNullOrEmpty(finalDishName))
                {
                    decimal price = _menuPrices[finalDishName];
                    decimal total = price * quantity;

                    if (dgv_thongke.InvokeRequired)
                    {
                        dgv_thongke.Invoke(new Action(() => {
                            dgv_thongke.Rows.Add(table, finalDishName, price, quantity, total);
                        }));
                    }
                    else
                    {
                        dgv_thongke.Rows.Add(table, finalDishName, price, quantity, total);
                    }
                    AppendLog($"Đặt món thành công: {table} - {finalDishName} x{quantity}");
                }
                else
                {
                    AppendLog($"Lỗi: {dishIdOrName}");
                }
            }
        }

        private void dgv_thongke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_thongke.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    tb_table.Text = row.Cells[0].Value.ToString();

                    tb_amount.Text = "0 VNĐ";
                }
            }
        }

        private void btn_charge_Click(object sender, EventArgs e)
        {
            string targetTable = tb_table.Text;

            if (string.IsNullOrEmpty(targetTable) || targetTable == "---")
            {
                MessageBox.Show("Vui lòng chọn một bàn từ danh sách để tính tiền!", "Thông báo");
                return;
            }

            decimal grandTotal = 0;
            var rowsForTable = new System.Collections.Generic.List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgv_thongke.Rows)
            {
                if (row.IsNewRow) continue;

                var cellTable = row.Cells[0].Value;

                if (cellTable != null && cellTable.ToString() == targetTable)
                {
                    var cellTotal = row.Cells[4].Value;

                    if (cellTotal != null)
                    {
                        if (decimal.TryParse(cellTotal.ToString(), out decimal rowAmount))
                        {
                            grandTotal += rowAmount;
                            rowsForTable.Add(row);
                        }
                    }
                }
            }

            tb_amount.Text = grandTotal.ToString("N0") + " VNĐ";

            AppendLog($"Đã tính tổng cho {targetTable}: {tb_amount.Text}");

            if (rowsForTable.Count > 0)
            {
                try
                {
                    string safeTable = targetTable.Replace(" ", "_");
                    foreach (var c in Path.GetInvalidFileNameChars()) safeTable = safeTable.Replace(c, '_');

                    string fileName = $"bill_{safeTable}.txt";
                    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                    var lines = new System.Collections.Generic.List<string>();
                    lines.Add($"HÓA ĐƠN BÀN {targetTable}");
                    lines.Add($"Ngày: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    lines.Add("");
                    lines.Add(string.Format("{0,-30} {1,12} {2,8} {3,14}", "Món ăn", "Đơn giá", "SL", "Thành tiền"));

                    foreach (var row in rowsForTable)
                    {
                        string dish = row.Cells[1].Value?.ToString() ?? "";
                        string unit = row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal u) ? u.ToString("N0") : "0";
                        string qty = row.Cells[3].Value?.ToString() ?? "0";
                        string tot = row.Cells[4].Value != null && decimal.TryParse(row.Cells[4].Value.ToString(), out decimal t) ? t.ToString("N0") : "0";

                        lines.Add(string.Format("{0,-30} {1,12} {2,8} {3,14}", dish, unit, qty, tot));
                    }

                    lines.Add("");
                    lines.Add(string.Format("{0,52} {1,14}", "Tổng cộng:", grandTotal.ToString("N0") + " VNĐ"));

                    File.WriteAllLines(filePath, lines, Encoding.UTF8);

                    AppendLog($"Đã xuất hóa đơn cho {targetTable}: {filePath}");
                    MessageBox.Show($"Đã xuất hóa đơn ra tệp:\n{filePath}", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất hóa đơn: " + ex.Message);
                    AppendLog("Lỗi xuất hóa đơn: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có món cho bàn này để xuất hóa đơn.", "Thông báo");
            }
        }

        private void AppendLog(string text)
        {
            if (rtb_log.InvokeRequired)
            {
                rtb_log.Invoke(new Action(() => {
                    rtb_log.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}{Environment.NewLine}");
                    rtb_log.ScrollToCaret();
                }));
            }
            else
            {
                rtb_log.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}{Environment.NewLine}");
                rtb_log.ScrollToCaret();
            }
        }
    }
}