using BankAPP.Models;

namespace BankAPP.Interfaces
{
    public interface ICardManager
    {
        Card CreateCard(User user);
        Card GetCard(string cardNumber);
        Card GetCard(User user, string cardNumber);
        void BlockCard(User user, string cardNumber);
        void UnblockCard(User user, string cardNumber);
    }
}
