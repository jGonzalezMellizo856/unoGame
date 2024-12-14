using System.Windows.Forms;
using System.Drawing;

namespace unoGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setupPanel = new System.Windows.Forms.Panel();
            this.startGameButton = new System.Windows.Forms.Button();
            this.showRulesButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.colorChoicePanel = new System.Windows.Forms.Panel();
            this.colorTitle = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.CurrentCardLabel = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.topCardLabel = new System.Windows.Forms.Label();
            this.deckCountLabel = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.drawCardButton = new System.Windows.Forms.Button();
            this.unoButton = new System.Windows.Forms.Button();
            this.topCardPanel = new System.Windows.Forms.Panel();
            this.setupPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.colorChoicePanel.SuspendLayout();
            this.topCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setupPanel
            // 
            this.setupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setupPanel.Controls.Add(this.startGameButton);
            this.setupPanel.Controls.Add(this.showRulesButton);
            this.setupPanel.Controls.Add(this.removePlayerButton);
            this.setupPanel.Controls.Add(this.playerListBox);
            this.setupPanel.Controls.Add(this.addPlayerButton);
            this.setupPanel.Controls.Add(this.playerNameTextBox);
            this.setupPanel.Controls.Add(this.playerNameLabel);
            this.setupPanel.Location = new System.Drawing.Point(14, 15);
            this.setupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.setupPanel.Name = "setupPanel";
            this.setupPanel.Size = new System.Drawing.Size(343, 869);
            this.setupPanel.TabIndex = 0;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Green;
            this.startGameButton.Enabled = false;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.startGameButton.ForeColor = System.Drawing.Color.White;
            this.startGameButton.Location = new System.Drawing.Point(14, 555);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(316, 60);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "START GAME";
            this.startGameButton.UseVisualStyleBackColor = false;
            // 
            // showRulesButton
            // 
            this.showRulesButton.BackColor = System.Drawing.Color.Blue;
            this.showRulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRulesButton.ForeColor = System.Drawing.Color.White;
            this.showRulesButton.Location = new System.Drawing.Point(14, 488);
            this.showRulesButton.Margin = new System.Windows.Forms.Padding(4);
            this.showRulesButton.Name = "showRulesButton";
            this.showRulesButton.Size = new System.Drawing.Size(316, 52);
            this.showRulesButton.TabIndex = 5;
            this.showRulesButton.Text = "Show Rules";
            this.showRulesButton.UseVisualStyleBackColor = false;
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.BackColor = System.Drawing.Color.Red;
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.ForeColor = System.Drawing.Color.White;
            this.removePlayerButton.Location = new System.Drawing.Point(14, 420);
            this.removePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(316, 52);
            this.removePlayerButton.TabIndex = 4;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            // 
            // playerListBox
            // 
            this.playerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerListBox.ItemHeight = 24;
            this.playerListBox.Location = new System.Drawing.Point(14, 105);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(316, 266);
            this.playerListBox.TabIndex = 3;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.Green;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.ForeColor = System.Drawing.Color.White;
            this.addPlayerButton.Location = new System.Drawing.Point(254, 48);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(69, 38);
            this.addPlayerButton.TabIndex = 2;
            this.addPlayerButton.Text = "Add";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(14, 52);
            this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(232, 29);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Location = new System.Drawing.Point(14, 15);
            this.playerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(138, 38);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player";
            // 
            // gamePanel
            // 
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.colorChoicePanel);
            this.gamePanel.Controls.Add(this.currentPlayerLabel);
            this.gamePanel.Controls.Add(this.topCardLabel);
            this.gamePanel.Controls.Add(this.deckCountLabel);
            this.gamePanel.Controls.Add(this.cardsPanel);
            this.gamePanel.Controls.Add(this.drawCardButton);
            this.gamePanel.Controls.Add(this.unoButton);
            this.gamePanel.Controls.Add(this.topCardPanel);
            this.gamePanel.Location = new System.Drawing.Point(371, 15);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1017, 869);
            this.gamePanel.TabIndex = 1;
            // 
            // colorChoicePanel
            // 
            this.colorChoicePanel.BackColor = System.Drawing.Color.White;
            this.colorChoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorChoicePanel.Controls.Add(this.colorTitle);
            this.colorChoicePanel.Controls.Add(this.redButton);
            this.colorChoicePanel.Controls.Add(this.blueButton);
            this.colorChoicePanel.Controls.Add(this.greenButton);
            this.colorChoicePanel.Controls.Add(this.yellowButton);
            this.colorChoicePanel.Location = new System.Drawing.Point(715, 224);
            this.colorChoicePanel.Margin = new System.Windows.Forms.Padding(4);
            this.colorChoicePanel.Name = "colorChoicePanel";
            this.colorChoicePanel.Size = new System.Drawing.Size(274, 224);
            this.colorChoicePanel.TabIndex = 6;
            this.colorChoicePanel.Visible = false;
            // 
            // colorTitle
            // 
            this.colorTitle.BackColor = System.Drawing.Color.Black;
            this.colorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.colorTitle.ForeColor = System.Drawing.Color.White;
            this.colorTitle.Location = new System.Drawing.Point(0, 0);
            this.colorTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorTitle.Name = "colorTitle";
            this.colorTitle.Size = new System.Drawing.Size(272, 45);
            this.colorTitle.TabIndex = 0;
            this.colorTitle.Text = "Choose a Color";
            this.colorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.redButton.ForeColor = System.Drawing.Color.White;
            this.redButton.Location = new System.Drawing.Point(7, 52);
            this.redButton.Margin = new System.Windows.Forms.Padding(4);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(124, 75);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "RED";
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.blueButton.ForeColor = System.Drawing.Color.White;
            this.blueButton.Location = new System.Drawing.Point(138, 52);
            this.blueButton.Margin = new System.Windows.Forms.Padding(4);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(124, 75);
            this.blueButton.TabIndex = 2;
            this.blueButton.Text = "BLUE";
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.greenButton.ForeColor = System.Drawing.Color.White;
            this.greenButton.Location = new System.Drawing.Point(7, 135);
            this.greenButton.Margin = new System.Windows.Forms.Padding(4);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(124, 75);
            this.greenButton.TabIndex = 3;
            this.greenButton.Text = "GREEN";
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.yellowButton.ForeColor = System.Drawing.Color.Black;
            this.yellowButton.Location = new System.Drawing.Point(138, 135);
            this.yellowButton.Margin = new System.Windows.Forms.Padding(4);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(124, 75);
            this.yellowButton.TabIndex = 4;
            this.yellowButton.Text = "YELLOW";
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // CurrentCardLabel
            // 
            this.CurrentCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentCardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentCardLabel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentCardLabel.Location = new System.Drawing.Point(0, 0);
            this.CurrentCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentCardLabel.Name = "CurrentCardLabel";
            this.CurrentCardLabel.Size = new System.Drawing.Size(276, 324);
            this.CurrentCardLabel.TabIndex = 0;
            this.CurrentCardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.Location = new System.Drawing.Point(14, 15);
            this.currentPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(412, 38);
            this.currentPlayerLabel.TabIndex = 0;
            this.currentPlayerLabel.Text = "Current Player:";
            // 
            // topCardLabel
            // 
            this.topCardLabel.Location = new System.Drawing.Point(14, 60);
            this.topCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topCardLabel.Name = "topCardLabel";
            this.topCardLabel.Size = new System.Drawing.Size(275, 38);
            this.topCardLabel.TabIndex = 1;
            this.topCardLabel.Text = "Top Card:";
            // 
            // deckCountLabel
            // 
            this.deckCountLabel.Location = new System.Drawing.Point(688, 15);
            this.deckCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deckCountLabel.Name = "deckCountLabel";
            this.deckCountLabel.Size = new System.Drawing.Size(275, 38);
            this.deckCountLabel.TabIndex = 2;
            this.deckCountLabel.Text = "Cards in Deck:";
            this.deckCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cardsPanel
            // 
            this.cardsPanel.AutoScroll = true;
            this.cardsPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.cardsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsPanel.Location = new System.Drawing.Point(14, 532);
            this.cardsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(989, 262);
            this.cardsPanel.TabIndex = 3;
            // 
            // drawCardButton
            // 
            this.drawCardButton.BackColor = System.Drawing.Color.Orange;
            this.drawCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawCardButton.ForeColor = System.Drawing.Color.White;
            this.drawCardButton.Location = new System.Drawing.Point(14, 810);
            this.drawCardButton.Margin = new System.Windows.Forms.Padding(4);
            this.drawCardButton.Name = "drawCardButton";
            this.drawCardButton.Size = new System.Drawing.Size(138, 45);
            this.drawCardButton.TabIndex = 4;
            this.drawCardButton.Text = "Draw Card";
            this.drawCardButton.UseVisualStyleBackColor = false;
            // 
            // unoButton
            // 
            this.unoButton.BackColor = System.Drawing.Color.Red;
            this.unoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unoButton.ForeColor = System.Drawing.Color.White;
            this.unoButton.Location = new System.Drawing.Point(866, 810);
            this.unoButton.Margin = new System.Windows.Forms.Padding(4);
            this.unoButton.Name = "unoButton";
            this.unoButton.Size = new System.Drawing.Size(138, 45);
            this.unoButton.TabIndex = 5;
            this.unoButton.Text = "UNO!";
            this.unoButton.UseVisualStyleBackColor = false;
            // 
            // topCardPanel
            // 
            this.topCardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topCardPanel.Controls.Add(this.CurrentCardLabel);
            this.topCardPanel.Location = new System.Drawing.Point(372, 148);
            this.topCardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topCardPanel.Name = "topCardPanel";
            this.topCardPanel.Size = new System.Drawing.Size(276, 324);
            this.topCardPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 900);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.setupPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNO Game";
            this.setupPanel.ResumeLayout(false);
            this.setupPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.colorChoicePanel.ResumeLayout(false);
            this.topCardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setupPanel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button showRulesButton;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label topCardLabel;
        private System.Windows.Forms.Button drawCardButton;
        private System.Windows.Forms.FlowLayoutPanel cardsPanel;
        private System.Windows.Forms.Panel colorChoicePanel;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Label deckCountLabel;
        private System.Windows.Forms.Button unoButton;
        private System.Windows.Forms.Label colorTitle;
        private Label CurrentCardLabel;
        private Panel topCardPanel;
    }
}

