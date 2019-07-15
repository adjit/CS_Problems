using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Problems.Cards
{
    interface ICard : ICardValue, ICardType, ISuit
    {
    }

    interface ISuit
    {
        CardSuit GetSuit();
    }

    interface ICardType
    {
        CardType GetCardType();
    }

    interface ICardValue
    {
        Object GetValue();
    }
}
