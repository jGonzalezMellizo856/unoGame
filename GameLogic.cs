using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unoGame
{
    internal class GameLogic
    {
        private DeckLogic deck;
        private List<Player> playerList;
        private CardLogic topCard;
        private int currentPlayer;
        private bool directionClockWise = true;
        private bool unoWasCalled = false;
        private List<CardLogic> discardPile;

        public GameLogic(List<string> playerName)
        {
            deck = new DeckLogic();
            deck.Shuffle();
            playerList = playerName.Select(name => new Player(name)).ToList();
            discardPile = new List<CardLogic>();

            // Deal initial cards
            foreach (var player in playerList)
            {
                for (int i = 0; i < 7; i++)
                    player.DrawCard(deck.DrawCard());
            }

            // Set initial top card (must be a number card)
            topCard = deck.DrawCard();
            while (topCard.Type != CardType.Number)
            {
                discardPile.Add(topCard);
                deck.AddCards(discardPile);
                discardPile.Clear();
                deck.Shuffle();
                topCard = deck.DrawCard();
            }
        }

        public void PlayTurn()
        {
            Player currentPlayer = playerList[this.currentPlayer];

            if (currentPlayer.PlayableCard(topCard))
            {
                CardLogic playedCard = currentPlayer.Hand.First(c =>
                    c.Color == topCard.Color ||
                    c.Type == topCard.Type ||
                    c.Color == CardColor.Wild
                );

                currentPlayer.PlayCard(playedCard);
                discardPile.Add(topCard);
                topCard = playedCard;
                ApplyCardEffect(playedCard);
            }
            else
            {
                // Draw card if no playable card
                if (deck.RemainingCards == 0)
                {
                    ReshuffleDiscardPile();
                }
                currentPlayer.DrawCard(deck.DrawCard());
            }

            NextPlayer();
        }

        private void ApplyCardEffect(CardLogic card)
        {
            switch (card.Type)
            {
                case CardType.Skip:
                    NextPlayer(); // Skip next player
                    break;

                case CardType.Reverse:
                    directionClockWise = !directionClockWise;
                    break;

                case CardType.DrawTwo:
                    int nextPlayer = GetNextPlayer();
                    for (int i = 0; i < 2; i++)
                    {
                        if (deck.RemainingCards == 0) ReshuffleDiscardPile();
                        playerList[nextPlayer].DrawCard(deck.DrawCard());
                    }
                    NextPlayer(); // Skip their turn
                    break;

                case CardType.WildDrawFour:
                    nextPlayer = GetNextPlayer();
                    for (int i = 0; i < 4; i++)
                    {
                        if (deck.RemainingCards == 0) ReshuffleDiscardPile();
                        playerList[nextPlayer].DrawCard(deck.DrawCard());
                    }
                    NextPlayer(); // Skip their turn
                    break;
            }
        }

        private void NextPlayer()
        {
            currentPlayer = (directionClockWise ?
                (currentPlayer + 1) % playerList.Count :
                (currentPlayer - 1 + playerList.Count) % playerList.Count
            );
        }

        private int GetNextPlayer()
        {
            return (directionClockWise ?
                (currentPlayer + 1) % playerList.Count :
                (currentPlayer - 1 + playerList.Count) % playerList.Count
            );
        }

        private void ReshuffleDiscardPile()
        {
            if (discardPile.Count > 1) // Keep current top card
            {
                var currentTop = discardPile[discardPile.Count - 1];
                discardPile.RemoveAt(discardPile.Count - 1);
                deck.AddCards(discardPile);
                discardPile.Clear();
                discardPile.Add(currentTop);
            }
        }

        // Methods needed for UI integration
        public string GetCurrentPlayerName() => playerList[currentPlayer].Name;
        public CardLogic GetTopCard() => topCard;
        public int GetDeckCount() => deck.GetCardCount();
        public List<CardLogic> GetCurrentPlayerHand() => playerList[currentPlayer].Hand;
        public bool IsValidMove(CardLogic card)
        {
            // Wild cards can always be played
            if (card.Type == CardType.WildCard || card.Type == CardType.WildDrawFour)
                return true;

            // For non-wild cards, check color or type match
            return card.Color == topCard.Color || 
                   (card.Type == topCard.Type && card.Type != CardType.Number) ||
                   (card.Type == CardType.Number && topCard.Type == CardType.Number && card.Number == topCard.Number);
        }
        public void SetWildCardColor(CardColor color)
        {
            if (color == CardColor.Wild)
                throw new ArgumentException("Cannot set wild as the chosen color");
            
            topCard.Color = color;
            
            // After color is set, apply effects and move to next player
            if (topCard.Type == CardType.WildDrawFour)
            {
                ApplyCardEffect(topCard);
            }
            NextPlayer();
        }
        public bool IsGameOver() => playerList.Any(p => p.Hand.Count == 0);
        public string GetWinner() => playerList.First(p => p.Hand.Count == 0).Name;
        public void CallUno() => unoWasCalled = true;

        public void PlayCard(CardLogic card)
        {
            Player currentPlayer = playerList[this.currentPlayer];
            
            // Check for UNO call
            if (currentPlayer.Hand.Count == 2 && !unoWasCalled)
            {
                // Penalty for not calling UNO
                DrawCard();
                DrawCard();
            }

            currentPlayer.PlayCard(card);
            discardPile.Add(topCard);
            topCard = card;

            // Don't apply effect for wild cards until color is chosen
            if (card.Type != CardType.WildCard && card.Type != CardType.WildDrawFour)
            {
                ApplyCardEffect(card);
                NextPlayer();
            }
            // Wild cards wait for color selection before moving to next player
            unoWasCalled = false;
        }

        public void DrawCard()
        {
            if (deck.RemainingCards == 0)
            {
                ReshuffleDiscardPile();
                if (deck.RemainingCards == 0) return;
            }

            playerList[currentPlayer].DrawCard(deck.DrawCard());
            NextPlayer();
        }

        public void DrawUntilPlayable()
        {
            Player currentPlayer = playerList[this.currentPlayer];
            
            // Keep drawing until player gets a playable card or deck is empty
            while (!currentPlayer.PlayableCard(topCard))
            {
                if (deck.RemainingCards == 0)
                {
                    ReshuffleDiscardPile();
                    if (deck.RemainingCards == 0) break; // No more cards to draw
                }
                currentPlayer.DrawCard(deck.DrawCard());
            }
            
            NextPlayer();
        }

        public bool ChallengeWildDrawFour()
        {
            // Get the previous player
            int previousPlayer = directionClockWise ? 
                (currentPlayer - 1 + playerList.Count) % playerList.Count : 
                (currentPlayer + 1) % playerList.Count;
            
            Player challenger = playerList[currentPlayer];
            Player challenged = playerList[previousPlayer];
            
            // Check if the previous player had any matching color cards
            bool wasIllegal = challenged.Hand.Any(card => 
                card.Color == topCard.Color && 
                card.Type != CardType.WildDrawFour);
            
            if (wasIllegal)
            {
                // Previous player draws 4 cards as penalty
                for (int i = 0; i < 4; i++)
                {
                    if (deck.RemainingCards == 0) ReshuffleDiscardPile();
                    challenged.DrawCard(deck.DrawCard());
                }
            }
            else
            {
                // Challenger draws 6 cards as penalty
                for (int i = 0; i < 6; i++)
                {
                    if (deck.RemainingCards == 0) ReshuffleDiscardPile();
                    challenger.DrawCard(deck.DrawCard());
                }
            }
            
            return wasIllegal;
        }
    }
}
