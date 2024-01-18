using BankAPP.Interfaces;
using BankAPP.Models;

namespace BankAPP.Services
{
    public class BankManager : IBankManager
    {
        AccountManager accountManager = new AccountManager();
        CardManager cardManager = new CardManager();
        Bank bank = new Bank("Najot Talim", "Fergana, Uzbekistan", "+998788889888", []);
        public void BlockCard(User user, string cardNumber)
        {
            cardManager.BlockCard(user, cardNumber);
        }

        public void CreateCard(User user)
        {
            cardManager.CreateCard(user);
        }

        public void Deposit(User user, string cardNumber)
        { 
            foreach(Card card in user.Cards)
            {
                if(card.Number == cardNumber)
                {
                    Console.WriteLine("Pul miqdorini kiriting");
                    double sum = double.Parse(Console.ReadLine());
                    card.Balance += sum;
                    user.Balance += sum;
                }
            }
        }

        public User Login()
        {
            return accountManager.Login();
        }

        public void Register()
        {
            accountManager.Register();
        }

        public void ShowAllBalance(User user)
        {
            Console.WriteLine(user.Balance);
        }

        public void ShowBalance(User user, string cardNumber)
        {
            foreach(Card card in user.Cards)
            {
                if(card.Number == cardNumber)
                {
                    Console.WriteLine(card.Balance);
                }
            }
        }

        public void ShowBankInfo()
        {
            bank.GetInfo();
        }

        public void ShowCards(User user)
        {
            foreach(Card card in user.Cards)
            {
                card.GetInfo();
            }
        }

        public void UnblockCard(User user, string cardNumber)
        {
            cardManager.UnblockCard(user,cardNumber);
        }

        public void Withdraw(User user, string cardNumber, string pin)
        {
            foreach(Card card in user.Cards)
            {
                if(card.Number == cardNumber && card.PinCode == pin) {
                    Console.WriteLine("Necha pul yechmoqchisiz");
                    double pul = double.Parse(Console.ReadLine());
                    if(card.Balance >= pul)
                    {
                        card.Balance -= pul;
                        user.Balance -= pul;
                        Console.WriteLine("Pul yechildi uni Tillayevdan olasiz");
                    }
                    else
                    {
                        Console.WriteLine("Hisobingizda mablag' mavjud emas");
                    }
                }
                else
                {
                    Console.WriteLine("Pinkodingiz xato");
                }
            }
        }
    }
}
