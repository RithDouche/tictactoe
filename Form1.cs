using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        //boolean to store if it is User's turn or Computer's
        private bool compTurn, userTurn;
        //stores player's sign
        private char compSign, userSign;
        //stores all the buttons
        List<Button> allBtn;
        //random number generator
        Random rand = new Random();
        //score count for both players
        Int32 compScore = 0;
        Int32 userScore = 0;
        //user win percentage 
        double winPerc = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add all the buttons into the list
            allBtn = new List<Button>
            {
                topR, topM,topL,middleR, middleM, middleL, bottomR, bottomM, bottomL
            };
            //assign reset button on the form1
            newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            //assign click button event
            UpdateScores();
            AssignClickEvents();
            DecideTurn();
        }

        private void AssignClickEvents()
        {
            // Assign the same event handler to all buttons
            List<Button> buttons = new List<Button> { topL, topM, topR, middleL, middleM, middleR, bottomL, bottomM, bottomR };
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;

            if (clickedBtn != null && string.IsNullOrEmpty(clickedBtn.Text))
            {
                if (userTurn && checkAvailable().Count > 0)
                {
                    //assign the button to X or O
                    clickedBtn.Text = userSign.ToString();

                    //checkWin
                    if (CheckWin())
                    {
                        MessageBox.Show("User Wins!");
                        userScore += 1;
                        UpdateScores();
                        userTurn = false;
                        return;
                    }

                    //switch to another player
                    switchPlay();
                }
            }

        }

        //switch turns for each player
        private void switchPlay()
        {
            compTurn = !compTurn;
            userTurn = !userTurn;

            if (compTurn) { computerMove(); }
        }

        private void computerMove()
        {
            //storing available move
            List<Button> availableBtn = checkAvailable();

            //check is there is any moves left
            if (availableBtn.Count > 0)
            {
                //computer makes a random moves through the availble bottuns count
                Button compChoice = availableBtn[rand.Next(availableBtn.Count)];

                //assign computer sign to the button
                compChoice.Text = compSign.ToString();

                //check win
                if (CheckWin())
                {
                    MessageBox.Show("Computer Wins!");
                    compScore += 1;
                    UpdateScores();
                    return;
                }
            }
            else
            {
                MessageBox.Show("It's a draw!");
                return;
            }

            //switch to another player
            switchPlay();
        }

        private List<Button> checkAvailable()
        {
            //add all available button into a list
            List<Button> availableBtn = new List<Button> { };
            foreach (Button button in allBtn)
            {
                if (string.IsNullOrEmpty(button.Text))
                {
                    availableBtn.Add(button);
                }
            }
            return availableBtn;
        }

        private void resetGame()
        {
            foreach (Button btn in allBtn)
            {
                btn.Text = "";
            }
            DecideTurn();

        }

        private void DecideTurn()
        {
            bool userGoesFirst = rand.Next(2) == 0;

            if (userGoesFirst)
            {
                turnDisplay.Text += "User (X)";
                userTurn = true;
                compTurn = false;
                userSign = 'X';
                compSign = 'O';

            }
            else
            {
                turnDisplay.Text += "Computer (X)";
                compTurn = true;
                userTurn = false;
                userSign = 'O';
                compSign = 'X';

                computerMove();
            }
        }

        

        private bool CheckWin()
        {
            Button[,] grid = new Button[,]
            {
                {topL, topM, topR},
                {middleL, middleM, middleR},
                {bottomL, bottomM, bottomR}
            };
            // Check winner in row
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0].Text == grid[i, 1].Text && grid[i, 1].Text == grid[i, 2].Text && !string.IsNullOrEmpty(grid[i, 0].Text))
                {
                    return true;
                }
            }
            // Check winner in column
            for (int j = 0; j < 3; j++)
            {
                if (grid[0, j].Text == grid[1, j].Text && grid[1, j].Text == grid[2, j].Text && !string.IsNullOrEmpty(grid[0, j].Text))
                {
                    return true;
                }
            }

            //Check winner diagonal right
            if (grid[0, 0].Text == grid[1, 1].Text && grid[1, 1].Text == grid[2, 2].Text && !string.IsNullOrEmpty(grid[0, 0].Text))
            {
                return true;
            }

            // Check winner diagonal left
            if (grid[0, 2].Text == grid[1, 1].Text && grid[1, 1].Text == grid[2, 0].Text && !string.IsNullOrEmpty(grid[0, 2].Text))
            {
                return true;
            }

            return false;
        }
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        //update score
        private void UpdateScores()
        {
            userSC.Text = $"User score - {userScore}";
            computerSC.Text = $"Computer Score - {compScore}";
            if (compScore == 0)
            {
                if (userScore > 0)
                {
                    winPerc = (double)userScore;
                }
                else if (userScore == 0)
                {
                    winPerc = 0.0;
                }
            }
            else if (compScore > 0 && userScore > 0)
            {
                {
                    winPerc = (double)userScore / (double)compScore;
                }
            }
            winPercentage.Text = $"Win % - {winPerc * 100}";

        }
    }
}
