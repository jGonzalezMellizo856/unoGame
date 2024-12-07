using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unoGame
{
    public enum CardColor { Red, Green, Blue, Yellow, Wild}
    
    public enum CardType { Number, Skip, DrawTwo, WildCard, WildDrawFour, Reverse}

    internal class CardLogic
    {
        public CardType Type { get; set; }
        public CardColor Color { get; set; }
        public int? Number { get; set; } // null for special cards

        public CardLogic(CardColor cardColor, CardType cardType, int? number = null)
        {
            Color = cardColor;
            Type = cardType;
            Number = number;

        }

        public override string ToString()
        {
            return $"{Color} {Type} {(Number.HasValue ? Number.ToString() : "")}";
        }



    }
}
