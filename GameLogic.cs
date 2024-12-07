using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unoGame
{
    internal class GameLogic
    {
        private DeckLogic deck;
        private List<Player> playerList;
        private CardLogic topCard;
        private int currentPlayer;
        private bool directionClockWise = true;

        public GameLogic (List<string> playerName)
        {
            deck = new DeckLogic ();
            deck.Shuffle();
            playerList = playerName.Select(name => new Player(name)).ToList();

            foreach(var player in playerList)
            {
                for (int i = 0; i < 7; i++)
                    player.DrawCard(deck.DrawCard());
            }

            topCard = deck.DrawCard();
            while(topCard.Type != CardType.Number)
            {
                deck.Shuffle();
                topCard = deck.DrawCard();
            }
        }

        public void PlayTurn()
        {
            Player currentPLayer = playerList[currentPlayer];

            if (currentPLayer.PlayableCard(topCard))
            {
                CardLogic playedCard = currentPLayer.Hand.First(c => 
                    c.Color == topCard.Color ||
                    c.Type == topCard.Type || 
                    c.Color == CardColor.Wild
                );

                currentPLayer.PlayCard(playedCard);
                ApplyCardEffect(playedCard);
                topCard = playedCard;
            }
            else
            {
                //draw card if there's no playable card inside own deck 
                currentPLayer.DrawCard(deck.DrawCard());
            }

            //move to the next player
            currentPlayer = (directionClockWise ?
                (currentPlayer + 1) % playerList.Count :
                (currentPlayer - 1 + playerList.Count) % playerList.Count
                );
        }

        private void ApplyCardEffect(CardLogic card)
        {
           switch (card.Type)
            {
                case CardType.Skip:
                    currentPlayer = (directionClockWise?
                        (currentPlayer + 1) % playerList.Count :
                        (currentPlayer - 1 + playerList.Count) % playerList.Count
                    );
                    break;
                case CardType.Reverse:
                    directionClockWise = !directionClockWise;
                    break;
                case CardType.WildCard:
                    //allow player to choose color 
                    //test and then add logic in order for player to choose cards
                    break;
                case CardType.WildDrawFour:
                    playerList[currentPlayer].DrawCard(deck.DrawCard());
                    playerList[currentPlayer].DrawCard(deck.DrawCard());
                    playerList[currentPlayer].DrawCard(deck.DrawCard());
                    playerList[currentPlayer].DrawCard(deck.DrawCard());
                    break;
            }
        }
    }
}
