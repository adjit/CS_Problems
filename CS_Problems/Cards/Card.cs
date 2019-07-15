using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Cards
{
    class CardValue : ICardValue
    {
        private Object _cardValue;

        public Object GetValue()
        {
            return _cardValue;
        }

        public CardValue(Object cardValue)
        {
            _cardValue = cardValue;
        }
    }

    class Card : ICard
    {
        private object _cardValue;
        private CardSuit _cardSuit;
        private CardType _cardType;

        public Card(object cardValue, CardSuit cardSuit, CardType cardType)
        {
            _cardValue = cardValue;
            _cardSuit = cardSuit;
            _cardType = cardType;
        }

        public CardType GetCardType()
        {
            return _cardType;
        }

        public CardSuit GetSuit()
        {
            return _cardSuit;
        }

        public object GetValue()
        {
            return _cardValue;
        }
    }
}
