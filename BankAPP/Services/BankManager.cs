using BankAPP.Interfaces;
using BankAPP.Models;

namespace BankAPP.Services
{
    public class BankManager : IBankManager
    {
        public void BlockCard(User user, string cardNumber)
        {
            
        }

        public void CreateCard(User user)
        {

        }

        public void Deposit(User user, string cardNumber)
        {
            throw new NotImplementedException();
        }

        public User Login()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void ShowAllBalance(User user)
        {
            throw new NotImplementedException();
        }

        public void ShowBalance(User user, string cardNumber)
        {
            throw new NotImplementedException();
        }

        public void ShowBankInfo()
        {
            throw new NotImplementedException();
        }

        public void ShowCards(User user)
        {
            throw new NotImplementedException();
        }

        public void UnblockCard(User user, string cardNumber)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(User user, string cardNumber, string pin)
        {
            throw new NotImplementedException();
        }
    }
}
