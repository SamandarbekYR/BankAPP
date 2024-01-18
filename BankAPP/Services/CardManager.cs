using BankAPP.Interfaces;
using BankAPP.Models;

namespace BankAPP.Services
{
    public class CardManager : ICardManager
    {
        private List<Card> cards = new List<Card>();
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
            Console.WriteLine("Karta raqamingiz");
            string CardNum = Console.ReadLine();
            Console.WriteLine("Pinkodingiz");
            string Pin = Console.ReadLine();
            Card card = new Card();
            card.Number = CardNum;
            card.PinCode = Pin;
            user.Cards.Add(card);
            cards.Add(card);
            return card;
        }

        public Card GetCard(string cardNumber)
        {
            foreach(Card card in cards)
            {
                if(card.Number == cardNumber)
                {
                    return card;
                }
            }
            return new Card();
        }

        public Card GetCard(User user, string cardNumber)
        {
            foreach(Card card in user.Cards)
            {
                if(card.Number == cardNumber)
                {
                    return card;
                }
            }
            return new Card();
        }

        public void UnblockCard(User user, string cardNumber)
        {
            foreach (Card card in user.Cards)
            {
                if (card.Number == cardNumber)
                {
                    card.Blocked = false;
                    break;
                }
            }
        }
    }
}
