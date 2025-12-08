namespace lab5_cau4
{
    public partial class Form1 : Form
    {
        private List<Ticket> bookedTickets = new List<Ticket>();
        private string selectedPosterPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectPoster_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn Poster phim";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPosterPath = openFileDialog.FileName;
                    picPoster.Image = Image.FromFile(selectedPosterPath);
                }
            }
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtMovieName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMovieName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Validate email format
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedPosterPath))
            {
                MessageBox.Show("Vui lòng chọn poster phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new ticket
            Ticket newTicket = new Ticket(
                txtMovieName.Text,
                txtCustomerName.Text,
                txtEmail.Text.ToLower(),
                (int)numSeatNumber.Value,
                txtSlogan.Text,
                selectedPosterPath
            );

            bookedTickets.Add(newTicket);

            // Check if customer already has tickets (same email)
            var customerTickets = bookedTickets.Where(t => t.Email == newTicket.Email).ToList();

            if (customerTickets.Count > 0)
            {
                // Group all seat numbers for this customer
                List<int> seatNumbers = customerTickets.Select(t => t.SeatNumber).ToList();

                // Send email with all tickets
                bool emailSent = EmailService.SendTicketConfirmation(
                    newTicket.Email,
                    newTicket.CustomerName,
                    newTicket.MovieName,
                    seatNumbers,
                    newTicket.Slogan,
                    newTicket.PosterPath
                );

                if (emailSent)
                {
                    MessageBox.Show(
                        $"Đặt vé thành công!\n\n" +
                        $"Khách hàng: {newTicket.CustomerName}\n" +
                        $"Email: {newTicket.Email}\n" +
                        $"Phim: {newTicket.MovieName}\n" +
                        $"Số ghế: {string.Join(", ", seatNumbers)}\n\n" +
                        $"Email xác nhận đã được gửi!",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Reset form for next booking
                    ResetForm();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMovieName.Clear();
            txtCustomerName.Clear();
            txtEmail.Clear();
            txtSlogan.Clear();
            numSeatNumber.Value = 1;
            picPoster.Image = null;
            selectedPosterPath = "";
            txtMovieName.Focus();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
