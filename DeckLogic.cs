using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unoGame
{
    internal class DeckLogic
    {
        private List<CardLogic> cards;
        private Random random  = new Random();

        public DeckLogic()
        {
            cards = new List<CardLogic>();


            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {

                if (color == CardColor.Wild) continue;

                for (int i = 0; i <= 9; i++) // Numbered cards 
                    cards.Add(new CardLogic(color, CardType.Number, i));

                for (int i = 1; i <= 9; i++) // duplicate non zero cards
                    cards.Add(new CardLogic(color, CardType.Number, i));


                cards.Add(new CardLogic(color, CardType.Skip));
                cards.Add(new CardLogic(color, CardType.Skip));
                cards.Add(new CardLogic(color, CardType.Reverse));
                cards.Add(new CardLogic(color, CardType.Reverse));
                cards.Add(new CardLogic(color, CardType.DrawTwo));
                cards.Add(new CardLogic(color, CardType.DrawTwo));
            }

            for (int i = 0; i < 4; i++)
            {
                cards.Add(new CardLogic(CardColor.Wild, CardType.WildCard));
                cards.Add(new CardLogic(CardColor.Wild, CardType.WildDrawFour));
            }
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        public CardLogic DrawCard() //test this method might not work as intended
        {
            if (cards.Count == 0)
                throw new InvalidCastException("Deck is Empty!");

            CardLogic drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public int RemainingCards => cards.Count;
    }
}
