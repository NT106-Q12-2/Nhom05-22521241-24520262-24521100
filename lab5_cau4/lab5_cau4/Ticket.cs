namespace lab5_cau4
{
    public class Ticket
    {
        public string MovieName { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int SeatNumber { get; set; }
        public string Slogan { get; set; }
        public string PosterPath { get; set; }

        public Ticket(string movieName, string customerName, string email, int seatNumber, string slogan, string posterPath)
        {
            MovieName = movieName;
            CustomerName = customerName;
            Email = email;
            SeatNumber = seatNumber;
            Slogan = slogan;
            PosterPath = posterPath;
        }
    }
}
