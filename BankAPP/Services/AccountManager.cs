using BankAPP.Interfaces;
using BankAPP.Models;

namespace BankAPP.Services
{
    public class AccountManager : IBankManager
    {
        private List<User> Users = new List<User>();
        public User Login()
        {
            User ans = new User();
            Console.WriteLine("Telefon Raqamingiz");
            string Number = Console.ReadLine();
            Console.WriteLine("Parolingiz");
            string Password = Console.ReadLine();
            foreach(User user in Users)
            {
                if (user.Password == Password && user.Phone == Number) {
                    return user;
                }
            }
            return ans;
        }

        public void Register()
        {
            Console.WriteLine("Ismingiz");
            string FullName = Console.ReadLine();
            Console.WriteLine("Telefon raqamingiz");
            string Phone = Console.ReadLine();
            Console.WriteLine("Parolingiz");
            string Password = Console.ReadLine();
            User user = new User();
            user.Password = Password;
            user.Phone = Phone;
            user.FullName = FullName;
            Users.Add(user);
        }
    }
}
