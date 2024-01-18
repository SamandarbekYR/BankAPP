namespace BankAPP.Models
{
    public class User
    {
        public string FullName { get; set; } = "";
        public string Password { get; set; } = "";
        public string Phone { get; set; } = "";
        public double Balance { get; set; } = 0.0;
        public DateTime LastLogin { get; set; } = DateTime.Now;
        public List<Card> Cards = { get; set; }
    }
}
