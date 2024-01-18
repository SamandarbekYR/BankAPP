namespace BankAPP.Models
{
    public class Bank : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone {  get; set; }
        public List<User> Users { get; set; }
    }
}
