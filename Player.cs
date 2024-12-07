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
            if (Hand.Contains(card)) Hand.Remove(card);
            else throw new InvalidOperationException("Card not in hand");
        }

        public bool PlayableCard(CardLogic card)
        {
            return Hand.Any(c =>
            c.Color == card.Color ||
            c.Type == card.Type ||
            c.Color == CardColor.Wild);
        }

    }
}
