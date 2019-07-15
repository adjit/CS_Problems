using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Cards
{
    class Deck
    {
        public List<Card> Cards;

        public Deck(List<Card> cards)
        {
            Cards = cards;
        }

        public Deck(TypeOfCardDeck deckType)
        {
            if (deckType == TypeOfCardDeck.PlayingCards)
            {
                Cards = _genericDeck();
            }
        }

        public Deck()
        {
            Cards = _genericDeck();
        }

        private List<Card> _genericDeck()
        {
            List<Card> cards = new List<Card>();

            foreach (CardSuit suit in (CardSuit[])Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardType type in (CardType[])Enum.GetValues(typeof(CardType)))
                {
                    cards.Add(new Card((int)type + 1, suit, type));
                }
            }

            return cards;
        }
    }

}
