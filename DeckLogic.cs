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
        private Random random = new Random();

        public DeckLogic()
        {
            cards = new List<CardLogic>();

            // Add numbered and special cards for each color
            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {
                if (color == CardColor.Wild) continue;

                // Add one zero card
                cards.Add(new CardLogic(color, CardType.Number, 0));

                // Add two of each number 1-9
                for (int i = 1; i <= 9; i++)
                {
                    cards.Add(new CardLogic(color, CardType.Number, i));
                    cards.Add(new CardLogic(color, CardType.Number, i));
                }

                // Add special cards (2 of each)
                for (int i = 0; i < 2; i++)
                {
                    cards.Add(new CardLogic(color, CardType.Skip));
                    cards.Add(new CardLogic(color, CardType.Reverse));
                    cards.Add(new CardLogic(color, CardType.DrawTwo));
                }
            }

            // Add Wild cards
            for (int i = 0; i < 4; i++)
            {
                cards.Add(new CardLogic(CardColor.Wild, CardType.WildCard));
                cards.Add(new CardLogic(CardColor.Wild, CardType.WildDrawFour));
            }

            // Shuffle the deck initially
            Shuffle();
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        public CardLogic DrawCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("Cannot draw from an empty deck!");

            CardLogic drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public void AddCards(List<CardLogic> cardsToAdd)
        {
            if (cardsToAdd == null || cardsToAdd.Count == 0)
                return;

            cards.AddRange(cardsToAdd);
            Shuffle(); // Shuffle after adding cards
        }

        public int RemainingCards => cards.Count;

        public int GetCardCount() => cards.Count;
    }
}
