using BankAPP.Interfaces;
using BankAPP.Models;

namespace BankAPP.Services
{
    public class CardManager : ICardManager
    {
        public void BlockCard(User user, string cardNumber)
        {
            foreach (Card card in user.Cards)
            {
                if (card.Number == cardNumber)
                {
                    card.Blocked = true;
                    break;
                }
            }
        }

        public Card CreateCard(User user)
        {
            throw new NotImplementedException();
        }

        public Card GetCard(string cardNumber)
        {
            throw new NotImplementedException();
        }

        public Card GetCard(User user, string cardNumber)
        {
            throw new NotImplementedException();
        }

        public void UnblockCard(User user, string cardNumber)
        {
            throw new NotImplementedException();
        }
    }
}
