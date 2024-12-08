using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unoGame
{
    internal class Player
    {
        public string Name {  get; set; }
        public List<CardLogic> Hand { get; private set; }
        
        public Player(string name)
        {
            Name = name;
            Hand = new List<CardLogic>();
        }

        public void DrawCard(CardLogic card)
        {
            Hand.Add(card);
        }

        public void PlayCard(CardLogic card)
        {
            if (Hand.Contains(card)) 
                Hand.Remove(card);
            else 
                throw new InvalidOperationException("Card not in hand");
        }

        public bool PlayableCard(CardLogic topCard)
        {
            return Hand.Any(card => 
                // Wild cards can always be played
                card.Type == CardType.WildCard || 
                card.Type == CardType.WildDrawFour ||
                // Match by color
                card.Color == topCard.Color ||
                // Match by type for special cards
                (card.Type == topCard.Type && card.Type != CardType.Number) ||
                // Match by number for number cards
                (card.Type == CardType.Number && topCard.Type == CardType.Number && card.Number == topCard.Number)
            );
        }

    }
}
