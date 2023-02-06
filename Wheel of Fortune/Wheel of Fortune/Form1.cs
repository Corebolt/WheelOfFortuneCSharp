using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Michael Feisthauer
//assignment 2 Final Part

namespace Wheel_of_Fortune
{
    public partial class Form1 : Form
    {
        Player newPlayer1;
        Player newPlayer2;
        Game newGame;

        //function
        public Form1()
        {
            InitializeComponent();
        }

        string generateHidden(int numLetters)
        {
            string dashes = "";
            for (int index = 0; index < numLetters; index++)
            {
                dashes += "-";
            }
            return dashes;
        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            gameStarter();
        }

        private void gameStarter()
        {
            newPlayer1 = new Player(playerOneName.Text);
            newPlayer2 = new Player(PlayerTwoName.Text);
            newGame = new Game();

            newPlayer1.PlayerName = playerOneName.Text;
            newPlayer2.PlayerName = PlayerTwoName.Text;

            player1Score.Text = 0 + "";
            player2Score.Text = 0 + "";
            
            playerGuess.Text = "";
            targetWord.Text = generateHidden(newGame.CurrentWord.Length);
            newGame.PlayerTurn = 0;
            changeCurrentPoints(randomizer());
            MessageBox.Show("Player one's turn");
        }

        public int randomizer()
        {
            Random random = new Random();
            int randomNum = random.Next() % 15;
            return randomNum;
        }

        private void changeCurrentPoints(int passedValue)
        {
            switch (passedValue)
            {
                case 0:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._100;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[0];
                    break;
                case 1:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._150;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[1];
                    break;
                case 2:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._200;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[2];
                    break;
                case 3:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._250;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[3];
                    break;
                case 4:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._300;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[4];
                    break;
                case 5:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._350;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[5];
                    break;
                case 6:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._400;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[6];
                    break;
                case 7:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._450;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[7];
                    break;
                case 8:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._5000;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[8];
                    break;
                case 9:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._550;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[9];
                    break;
                case 10:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._600;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[10];
                    break;
                case 11:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._700;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[11];
                    break;
                case 12:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._750;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[12];
                    break;
                case 13:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._800;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[13];
                    break;
                case 14:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources._900;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[14];
                    break;
                case 15:
                    CurrentPoints.Image = Wheel_of_Fortune.Properties.Resources.bankrupt;
                    newGame.CurrentPrizeAmount = newGame.PrizeAmounts[15];
                    break;
            }
        }

        private void pointsUpdate()
        {
            if (newGame.PlayerTurn == 0)
            {
                newPlayer1.PlayerScore += newGame.CurrentPrizeAmount;
                if (newGame.CurrentPrizeAmount == 0)
                    newPlayer1.PlayerScore = 0; //bankrupt function
                player1Score.Text = newPlayer1.PlayerScore.ToString();
                
            }
            else
            {
                newPlayer2.PlayerScore += newGame.CurrentPrizeAmount;
                if (newGame.CurrentPrizeAmount == 0)
                    newPlayer2.PlayerScore = 0; //bankrupt function
                player2Score.Text = newPlayer2.PlayerScore.ToString();
                
            }

            changeCurrentPoints(randomizer());

        }

        private void turnChange()
        {
            if(newGame.PlayerTurn == 0)
            {
                MessageBox.Show("Player two's turn");
                newGame.PlayerTurn = 1;
            }
            else 
            {
                MessageBox.Show("Player one's turn");
                newGame.PlayerTurn = 0;
            }
            playerGuess.Text = "";
        }

        private void wrongLetter(bool correct)
        {            
            if(correct == false)
                MessageBox.Show("Wrong letter");                    
        }

        private void winner(bool correct)
        {
            if (correct == true)
            {
                string winner = newPlayer2.PlayerName;
                if (newPlayer1.PlayerScore > newPlayer2.PlayerScore)
                {
                    player1Score.Text = newPlayer1.PlayerScore.ToString();
                    winner = newPlayer1.PlayerName;
                }
                else
                {
                    player2Score.Text = newPlayer2.PlayerScore.ToString();
                    winner = newPlayer2.PlayerName;
                }
                MessageBox.Show(winner + " has won");

                DialogResult response;
                response = MessageBox.Show("Would you like to play again? ", "",
                                MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    gameStarter();
                }
                else if (response == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        private void SubmitGuess_Click(object sender, EventArgs e)
        {            
            char playerLetter = playerGuess.Text.ToLower()[0];
            char[] letters = targetWord.Text.ToCharArray();
            bool correct = false;
            bool correctLetter = false;
            
            for (int index = 0; index < targetWord.Text.Length; index++)
            {

                if (newGame.CurrentWord[index] == playerLetter)
                {
                    letters[index] = playerLetter;
                    pointsUpdate();
                    correctLetter = true;

                    
                }                 
            }
            targetWord.Text = new string(letters);
            if (targetWord.Text == newGame.CurrentWord)
            {
                correct = true;
            }
            winner(correct);
            wrongLetter(correctLetter);
            turnChange();                      
        }               
    }
}  