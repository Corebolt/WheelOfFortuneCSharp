// Michael Feisthauer

namespace Wheel_of_Fortune
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
            this.components = new System.ComponentModel.Container();
            this.targetWord = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playerGuess = new System.Windows.Forms.TextBox();
            this.PlayerTwoName = new System.Windows.Forms.TextBox();
            this.playerOneName = new System.Windows.Forms.TextBox();
            this.playerTwo = new System.Windows.Forms.TextBox();
            this.playerOne = new System.Windows.Forms.TextBox();
            this.Score1 = new System.Windows.Forms.TextBox();
            this.Score2 = new System.Windows.Forms.TextBox();
            this.gameStart = new System.Windows.Forms.Button();
            this.CurrentPoints = new System.Windows.Forms.PictureBox();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.player1Score = new System.Windows.Forms.TextBox();
            this.SubmitGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // targetWord
            // 
            this.targetWord.Location = new System.Drawing.Point(498, 190);
            this.targetWord.Name = "targetWord";
            this.targetWord.ReadOnly = true;
            this.targetWord.Size = new System.Drawing.Size(182, 20);
            this.targetWord.TabIndex = 0;
            this.targetWord.Text = "Target Word";
            this.targetWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // playerGuess
            // 
            this.playerGuess.Location = new System.Drawing.Point(546, 214);
            this.playerGuess.Name = "playerGuess";
            this.playerGuess.Size = new System.Drawing.Size(100, 20);
            this.playerGuess.TabIndex = 1;
            this.playerGuess.Text = "Player Guess";
            // 
            // PlayerTwoName
            // 
            this.PlayerTwoName.Location = new System.Drawing.Point(618, 66);
            this.PlayerTwoName.Name = "PlayerTwoName";
            this.PlayerTwoName.Size = new System.Drawing.Size(170, 20);
            this.PlayerTwoName.TabIndex = 2;
            this.PlayerTwoName.Text = "Player Two Name";
            this.PlayerTwoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerOneName
            // 
            this.playerOneName.Location = new System.Drawing.Point(389, 66);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(172, 20);
            this.playerOneName.TabIndex = 3;
            this.playerOneName.Text = "Player One Name";
            this.playerOneName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerTwo
            // 
            this.playerTwo.Location = new System.Drawing.Point(618, 40);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.ReadOnly = true;
            this.playerTwo.Size = new System.Drawing.Size(170, 20);
            this.playerTwo.TabIndex = 4;
            this.playerTwo.Text = "PLAYER TWO";
            this.playerTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerOne
            // 
            this.playerOne.Location = new System.Drawing.Point(389, 40);
            this.playerOne.Name = "playerOne";
            this.playerOne.ReadOnly = true;
            this.playerOne.Size = new System.Drawing.Size(172, 20);
            this.playerOne.TabIndex = 5;
            this.playerOne.Text = "PLAYER ONE";
            this.playerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score1
            // 
            this.Score1.Location = new System.Drawing.Point(421, 92);
            this.Score1.Name = "Score1";
            this.Score1.ReadOnly = true;
            this.Score1.Size = new System.Drawing.Size(100, 20);
            this.Score1.TabIndex = 7;
            this.Score1.Text = "Current Score ";
            this.Score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score2
            // 
            this.Score2.Location = new System.Drawing.Point(652, 92);
            this.Score2.Name = "Score2";
            this.Score2.ReadOnly = true;
            this.Score2.Size = new System.Drawing.Size(100, 20);
            this.Score2.TabIndex = 9;
            this.Score2.Text = "Current Score ";
            this.Score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameStart
            // 
            this.gameStart.Location = new System.Drawing.Point(458, 265);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(103, 59);
            this.gameStart.TabIndex = 10;
            this.gameStart.Text = "Start Game";
            this.gameStart.UseVisualStyleBackColor = true;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // CurrentPoints
            // 
            this.CurrentPoints.Image = global::Wheel_of_Fortune.Properties.Resources.wheelOfFortuneGIF;
            this.CurrentPoints.Location = new System.Drawing.Point(12, 66);
            this.CurrentPoints.Name = "CurrentPoints";
            this.CurrentPoints.Size = new System.Drawing.Size(346, 349);
            this.CurrentPoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentPoints.TabIndex = 12;
            this.CurrentPoints.TabStop = false;
            // 
            // player2Score
            // 
            this.player2Score.Location = new System.Drawing.Point(652, 118);
            this.player2Score.Name = "player2Score";
            this.player2Score.ReadOnly = true;
            this.player2Score.Size = new System.Drawing.Size(100, 20);
            this.player2Score.TabIndex = 13;
            this.player2Score.Text = "Score here";
            this.player2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Score
            // 
            this.player1Score.Location = new System.Drawing.Point(421, 118);
            this.player1Score.Name = "player1Score";
            this.player1Score.ReadOnly = true;
            this.player1Score.Size = new System.Drawing.Size(100, 20);
            this.player1Score.TabIndex = 14;
            this.player1Score.Text = "Score here";
            this.player1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubmitGuess
            // 
            this.SubmitGuess.Location = new System.Drawing.Point(618, 266);
            this.SubmitGuess.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitGuess.Name = "SubmitGuess";
            this.SubmitGuess.Size = new System.Drawing.Size(89, 58);
            this.SubmitGuess.TabIndex = 15;
            this.SubmitGuess.Text = "Submit Guess";
            this.SubmitGuess.UseVisualStyleBackColor = true;
            this.SubmitGuess.Click += new System.EventHandler(this.SubmitGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitGuess);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.CurrentPoints);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOneName);
            this.Controls.Add(this.PlayerTwoName);
            this.Controls.Add(this.playerGuess);
            this.Controls.Add(this.targetWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetWord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox playerGuess;
        private System.Windows.Forms.TextBox PlayerTwoName;
        private System.Windows.Forms.TextBox playerOneName;
        private System.Windows.Forms.TextBox playerTwo;
        private System.Windows.Forms.TextBox playerOne;
        private System.Windows.Forms.TextBox Score1;
        private System.Windows.Forms.TextBox Score2;
        private System.Windows.Forms.Button gameStart;
        private System.Windows.Forms.PictureBox CurrentPoints;
        private System.Windows.Forms.TextBox player2Score;
        private System.Windows.Forms.TextBox player1Score;
        private System.Windows.Forms.Button SubmitGuess;
    }
}

