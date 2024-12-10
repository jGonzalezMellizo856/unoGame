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
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.colorTitle = new System.Windows.Forms.Label();
            this.unoButton = new System.Windows.Forms.Button();
            this.drawCardButton = new System.Windows.Forms.Button();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deckCountLabel = new System.Windows.Forms.Label();
            this.topCardLabel = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.setupPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.colorChoicePanel.SuspendLayout();
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
            this.setupPanel.Location = new System.Drawing.Point(10, 10);
            this.setupPanel.Name = "setupPanel";
            this.setupPanel.Size = new System.Drawing.Size(250, 580);
            this.setupPanel.TabIndex = 0;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Green;
            this.startGameButton.Enabled = false;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.startGameButton.ForeColor = System.Drawing.Color.White;
            this.startGameButton.Location = new System.Drawing.Point(10, 370);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(230, 40);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "START GAME";
            this.startGameButton.UseVisualStyleBackColor = false;
            // 
            // showRulesButton
            // 
            this.showRulesButton.BackColor = System.Drawing.Color.Blue;
            this.showRulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRulesButton.ForeColor = System.Drawing.Color.White;
            this.showRulesButton.Location = new System.Drawing.Point(10, 325);
            this.showRulesButton.Name = "showRulesButton";
            this.showRulesButton.Size = new System.Drawing.Size(230, 35);
            this.showRulesButton.TabIndex = 5;
            this.showRulesButton.Text = "Show Rules";
            this.showRulesButton.UseVisualStyleBackColor = false;
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.BackColor = System.Drawing.Color.Red;
            this.removePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerButton.ForeColor = System.Drawing.Color.White;
            this.removePlayerButton.Location = new System.Drawing.Point(10, 280);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(230, 35);
            this.removePlayerButton.TabIndex = 4;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            // 
            // playerListBox
            // 
            this.playerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerListBox.ItemHeight = 20;
            this.playerListBox.Location = new System.Drawing.Point(10, 70);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(230, 182);
            this.playerListBox.TabIndex = 3;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.Green;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.ForeColor = System.Drawing.Color.White;
            this.addPlayerButton.Location = new System.Drawing.Point(190, 35);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(50, 25);
            this.addPlayerButton.TabIndex = 2;
            this.addPlayerButton.Text = "Add";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(10, 35);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(170, 26);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Location = new System.Drawing.Point(10, 10);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(100, 25);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player";
            // 
            // gamePanel
            // 
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.currentPlayerLabel);
            this.gamePanel.Controls.Add(this.topCardLabel);
            this.gamePanel.Controls.Add(this.deckCountLabel);
            this.gamePanel.Controls.Add(this.cardsPanel);
            this.gamePanel.Controls.Add(this.drawCardButton);
            this.gamePanel.Controls.Add(this.unoButton);
            this.gamePanel.Controls.Add(this.colorChoicePanel);
            this.gamePanel.Location = new System.Drawing.Point(270, 10);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(740, 580);
            this.gamePanel.TabIndex = 1;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.Location = new System.Drawing.Point(10, 10);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(300, 25);
            this.currentPlayerLabel.TabIndex = 0;
            this.currentPlayerLabel.Text = "Current Player:";
            // 
            // topCardLabel
            // 
            this.topCardLabel.Location = new System.Drawing.Point(10, 40);
            this.topCardLabel.Name = "topCardLabel";
            this.topCardLabel.Size = new System.Drawing.Size(200, 25);
            this.topCardLabel.TabIndex = 1;
            this.topCardLabel.Text = "Top Card:";
            // 
            // deckCountLabel
            // 
            this.deckCountLabel.Location = new System.Drawing.Point(500, 10);
            this.deckCountLabel.Name = "deckCountLabel";
            this.deckCountLabel.Size = new System.Drawing.Size(200, 25);
            this.deckCountLabel.TabIndex = 2;
            this.deckCountLabel.Text = "Cards in Deck:";
            this.deckCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cardsPanel
            // 
            this.cardsPanel.AutoScroll = true;
            this.cardsPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.cardsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsPanel.Location = new System.Drawing.Point(10, 70);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(720, 460);
            this.cardsPanel.TabIndex = 3;
            // 
            // drawCardButton
            // 
            this.drawCardButton.BackColor = System.Drawing.Color.Orange;
            this.drawCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawCardButton.ForeColor = System.Drawing.Color.White;
            this.drawCardButton.Location = new System.Drawing.Point(10, 540);
            this.drawCardButton.Name = "drawCardButton";
            this.drawCardButton.Size = new System.Drawing.Size(100, 30);
            this.drawCardButton.TabIndex = 4;
            this.drawCardButton.Text = "Draw Card";
            this.drawCardButton.UseVisualStyleBackColor = false;
            // 
            // unoButton
            // 
            this.unoButton.BackColor = System.Drawing.Color.Red;
            this.unoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unoButton.ForeColor = System.Drawing.Color.White;
            this.unoButton.Location = new System.Drawing.Point(630, 540);
            this.unoButton.Name = "unoButton";
            this.unoButton.Size = new System.Drawing.Size(100, 30);
            this.unoButton.TabIndex = 5;
            this.unoButton.Text = "UNO!";
            this.unoButton.UseVisualStyleBackColor = false;
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
            this.colorChoicePanel.Location = new System.Drawing.Point(270, 200);
            this.colorChoicePanel.Name = "colorChoicePanel";
            this.colorChoicePanel.Size = new System.Drawing.Size(200, 150);
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
            this.colorTitle.Name = "colorTitle";
            this.colorTitle.Size = new System.Drawing.Size(198, 30);
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
            this.redButton.Location = new System.Drawing.Point(5, 35);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(90, 50);
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
            this.blueButton.Location = new System.Drawing.Point(100, 35);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(90, 50);
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
            this.greenButton.Location = new System.Drawing.Point(5, 90);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(90, 50);
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
            this.yellowButton.Location = new System.Drawing.Point(100, 90);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(90, 50);
            this.yellowButton.TabIndex = 4;
            this.yellowButton.Text = "YELLOW";
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.setupPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNO Game";
            this.setupPanel.ResumeLayout(false);
            this.setupPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.colorChoicePanel.ResumeLayout(false);
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
    }
}

