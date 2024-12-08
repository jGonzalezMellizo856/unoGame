using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace unoGame
{
    public partial class Form1 : Form
    {
        private GameLogic gameLogic;
        private List<string> players;
        private Dictionary<Button, CardLogic> cardButtons;
        private const int MAX_PLAYERS = 5;
        private CardLogic currentWildCard = null;

        public Form1()
        {
            InitializeComponent();
            players = new List<string>();
            cardButtons = new Dictionary<Button, CardLogic>();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Setup panel event handlers
            addPlayerButton.Click += AddPlayerButton_Click;
            removePlayerButton.Click += RemovePlayerButton_Click;
            startGameButton.Click += StartGameButton_Click;
            showRulesButton.Click += ShowRulesButton_Click;
            playerNameTextBox.KeyPress += PlayerNameTextBox_KeyPress;

            // Game panel event handlers
            drawCardButton.Click += DrawCardButton_Click;
            unoButton.Click += UnoButton_Click;

            // Color choice buttons
            redButton.Click += (s, e) => ColorButton_Click(CardColor.Red);
            blueButton.Click += (s, e) => ColorButton_Click(CardColor.Blue);
            greenButton.Click += (s, e) => ColorButton_Click(CardColor.Green);
            yellowButton.Click += (s, e) => ColorButton_Click(CardColor.Yellow);
        }

        private void PlayerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddPlayerButton_Click(sender, e);
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if (players.Count >= MAX_PLAYERS)
            {
                MessageBox.Show($"Maximum {MAX_PLAYERS} players allowed.", "Too Many Players");
                return;
            }

            string playerName = playerNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Please enter a player name.", "Invalid Input");
                return;
            }

            if (players.Contains(playerName))
            {
                MessageBox.Show("This player name already exists.", "Duplicate Name");
                return;
            }

            players.Add(playerName);
            playerListBox.Items.Add(playerName);
            playerNameTextBox.Clear();
            playerNameTextBox.Focus();

            // Enable/disable buttons based on player count
            startGameButton.Enabled = players.Count >= 2;
            removePlayerButton.Enabled = players.Count > 0;
            addPlayerButton.Enabled = players.Count < MAX_PLAYERS;
        }

        private void RemovePlayerButton_Click(object sender, EventArgs e)
        {
            if (playerListBox.SelectedIndex != -1)
            {
                players.RemoveAt(playerListBox.SelectedIndex);
                playerListBox.Items.RemoveAt(playerListBox.SelectedIndex);
                startGameButton.Enabled = players.Count >= 2;
                removePlayerButton.Enabled = players.Count > 0;
            }
            else
            {
                MessageBox.Show("Please select a player to remove.", "No Selection");
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            if (players.Count < 2)
            {
                MessageBox.Show("At least 2 players are required to start the game.", "Not Enough Players");
                return;
            }

            gameLogic = new GameLogic(players);
            setupPanel.Visible = false;
            gamePanel.Visible = true;
            UpdateGameState();
        }

        private void ShowRulesButton_Click(object sender, EventArgs e)
        {
            string rules = @"UNO Rules:

1. Each player starts with 7 cards
2. Match the top card by number, color, or symbol
3. Special cards:
   - Skip: Next player loses their turn
   - Reverse: Changes direction of play
   - Draw Two: Next player draws 2 cards and loses their turn
   - Wild: Change the color of play
   - Wild Draw Four: Change color and next player draws 4 cards

4. When you have one card left, you must click the UNO button
5. First player to get rid of all their cards wins!";

            MessageBox.Show(rules, "UNO Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateGameState()
        {
            // Clear existing card buttons
            cardsPanel.Controls.Clear();
            cardButtons.Clear();

            // Update labels
            currentPlayerLabel.Text = $"Current Player: {gameLogic.GetCurrentPlayerName()}";
            topCardLabel.Text = $"Top Card: {gameLogic.GetTopCard()}";
            deckCountLabel.Text = $"Cards in Deck: {gameLogic.GetDeckCount()}";

            // Set bold fonts for labels at runtime
            if (currentPlayerLabel.Font.Style != FontStyle.Bold)
                currentPlayerLabel.Font = new Font(currentPlayerLabel.Font, FontStyle.Bold);
            if (topCardLabel.Font.Style != FontStyle.Bold)
                topCardLabel.Font = new Font(topCardLabel.Font, FontStyle.Bold);
            if (deckCountLabel.Font.Style != FontStyle.Bold)
                deckCountLabel.Font = new Font(deckCountLabel.Font, FontStyle.Bold);

            // Create buttons for current player's cards
            var currentPlayerHand = gameLogic.GetCurrentPlayerHand();
            foreach (var card in currentPlayerHand)
            {
                Button cardButton = CreateCardButton(card);
                cardsPanel.Controls.Add(cardButton);
                cardButtons[cardButton] = card;
            }

            // Show/hide UNO button based on card count
            unoButton.Enabled = currentPlayerHand.Count == 1;
        }

        private Button CreateCardButton(CardLogic card)
        {
            Button cardButton = new Button
            {
                Width = 90,
                Height = 130,
                Margin = new Padding(5),
                Text = card.ToString(),
                BackColor = GetCardColor(card.Color),
                ForeColor = card.Color == CardColor.Yellow ? Color.Black : Color.White,
                FlatStyle = FlatStyle.Flat
            };
            cardButton.Click += CardButton_Click;
            return cardButton;
        }

        private Color GetCardColor(CardColor cardColor)
        {
            switch (cardColor)
            {
                case CardColor.Red: return Color.Red;
                case CardColor.Blue: return Color.Blue;
                case CardColor.Green: return Color.Green;
                case CardColor.Yellow: return Color.Yellow;
                default: return Color.Gray;
            }
        }

        private void ShowColorChoicePanel()
        {
            // Center the panel in the game panel
            colorChoicePanel.Location = new Point(
                gamePanel.Width / 2 - colorChoicePanel.Width / 2,
                gamePanel.Height / 2 - colorChoicePanel.Height / 2
            );
            colorChoicePanel.BringToFront();
            colorChoicePanel.Visible = true;

            // Disable other controls while choosing color
            cardsPanel.Enabled = false;
            drawCardButton.Enabled = false;
            unoButton.Enabled = false;
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            CardLogic selectedCard = cardButtons[clickedButton];

            if (gameLogic.IsValidMove(selectedCard))
            {
                if (selectedCard.Type == CardType.WildCard || selectedCard.Type == CardType.WildDrawFour)
                {
                    // Store the selected card temporarily
                    currentWildCard = selectedCard;
                    // Show color choice panel in center of game panel
                    colorChoicePanel.Location = new Point(
                        (gamePanel.Width - colorChoicePanel.Width) / 2,
                        (gamePanel.Height - colorChoicePanel.Height) / 2
                    );
                    colorChoicePanel.BringToFront();
                    colorChoicePanel.Visible = true;
                    return;
                }

                PlayCard(selectedCard);
            }
            else
            {
                MessageBox.Show("Invalid move! Please select a matching card or draw from the deck.", "Invalid Move");
            }
        }

        private void ColorButton_Click(CardColor color)
        {
            if (currentWildCard != null)
            {
                PlayCard(currentWildCard);
                gameLogic.SetWildCardColor(color);
                currentWildCard = null;
                colorChoicePanel.Visible = false;
                
                // Re-enable controls after color selection
                cardsPanel.Enabled = true;
                drawCardButton.Enabled = true;
                unoButton.Enabled = gameLogic.GetCurrentPlayerHand().Count == 1;
                
                UpdateGameState();
            }
        }

        private void PlayCard(CardLogic card)
        {
            gameLogic.PlayCard(card);
            
            if (gameLogic.IsGameOver())
            {
                string winner = gameLogic.GetWinner();
                MessageBox.Show($"Game Over! {winner} wins!", "Game Over");
                Application.Restart();
                return;
            }

            UpdateGameState();
        }

        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            gameLogic.DrawUntilPlayable();
            UpdateGameState();
        }

        private void UnoButton_Click(object sender, EventArgs e)
        {
            if (gameLogic.GetCurrentPlayerHand().Count == 1)
            {
                MessageBox.Show("UNO! called successfully!", "UNO!");
            }
            else
            {
                MessageBox.Show("You can only call UNO! when you have one card left!", "Invalid UNO!");
            }
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
