//////////////////////////////////////////
/// Name                Date        Description
/// Sotharith Sieng     2/12/25     
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
            //assign reset button
            //update score on load
            UpdateScores();
            //assign buttons to be clicked
            AssignClickEvents();
            //decide user turn or computer turn
            DecideTurn();
        }

        private void AssignClickEvents()
        {
            // Assign the same event handler to all buttons
            List<Button> buttons = new List<Button> { topL, topM, topR, middleL, middleM, middleR, bottomL, bottomM, bottomR };
            //assigning Button_Click method to each button of the game to 
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        //handle user click
        private void Button_Click(object sender, EventArgs e)
        {
            // Prevent moves if the game is stopped
            if (gameStopped) return;

            // Button variable to store what button the user clicked
            Button clickedBtn = sender as Button;

            // Check if button exists and is empty
            if (clickedBtn != null && string.IsNullOrEmpty(clickedBtn.Text))
            {
                // Check if it is user turn and there are available moves
                if (userTurn && checkAvailable().Count > 0)
                {
                    // Assign the button to X or O with user's sign
                    clickedBtn.Text = userSign.ToString();

                    // Check if the user wins
                    if (CheckWin())
                    {
                        // Display winner message
                        winBox.Text = "Winner: " + Environment.NewLine + "User Wins!";
                        // Increase user score
                        userScore += 1;
                        // Update the score display
                        UpdateScores();
                        // End the turn
                        endTurn();
                        // Exit method
                        return;
                    }
                    else if (checkAvailable().Count == 0)
                    {
                        //message box display that it is a draw
                        winBox.Text = "It's a draw!";
                        //end both turn
                        endTurn();
                        //exit from method
                        return;
                    }

                    // Switch to the next player
                    switchPlay();
                }
            }
        }


        //switch turns for each player
        private void switchPlay()
        {
            compTurn = !compTurn;
            userTurn = !userTurn;

            //if it is computer turn, computer makes a move
            if (compTurn) { computerMove(); }
        }

        //computer move
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
                    //message box display that the computer won
                    winBox.Text = "Winner:" + Environment.NewLine + "Computer Wins!";
                    //add score to computer
                    compScore += 1;
                    //update score display
                    UpdateScores();
                    //exit from the method
                    return;
                }
                //check draw
                else if (checkAvailable().Count == 0)
                {
                    //message box display that it is a draw
                    winBox.Text = "It's a draw!";
                    //end both turn
                    endTurn();
                    endTurn();
                    //exit from method
                    return;
                }
            }

            //switch to another player
            switchPlay();
        }
        //end both turns

        // A flag to track whether the game has stopped or not
        private bool gameStopped = false;
        private void stopGame_Click(object sender, EventArgs e)
        {
            // Toggle if game is stopped
            gameStopped = !gameStopped;

            if (gameStopped)
            {
                stopGame.Text = "Resume Game";
            }
            else
            {
                stopGame.Text = "Stop Game";
            }
        }



        // Ends turn for both users, preventing anyone from clicking
        private void endTurn()
        {
            compTurn = false;
            userTurn = false ;
        }

        // Check if there's an available button left that does not have a symbol in it
        private List<Button> checkAvailable()
        {
            //add all available button into a list
            List<Button> availableBtn = new List<Button> { };
            //go through all the buttons
            foreach (Button button in allBtn)
            {
                //if button hasn't been clicked it will be added to available list
                if (string.IsNullOrEmpty(button.Text))
                {
                    availableBtn.Add(button);
                }
            }
            return availableBtn;
        }

        //reset the game
        private void resetGame()
        {
            //add score to computer if the player moves and resets game
            if (checkAvailable().Count < 8 && checkAvailable().Count > 0)
            {
                if(!CheckWin())
                {
                    compScore++;
                }
            }

            //go through each button and remove text
            foreach (Button btn in allBtn)
            {
                btn.Text = "";
            }
            //update score
            UpdateScores();
            //decide who goes first after reseting the game
            DecideTurn();
        }

        //decide who goes first
        private void DecideTurn()
        {
            bool userGoesFirst = rand.Next(2) == 0;

            if (userGoesFirst)
            {
                turnDisplay.Text = "Turn: User (X)";
                userTurn = true;
                compTurn = false;
                userSign = 'X';
                compSign = 'O';
            }
            else
            {
                turnDisplay.Text = "Turn: Computer (X)";
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
        
        //calls reset game method when the button is clicked
        resetGame();
        winBox.Text = "Winner:";
        
        //update score and win percentage
        }

        //new game button

        private void UpdateScores()
        {
            //update the score onto the textbox
            userSC.Text = $"User score - {userScore}";
            computerSC.Text = $"Computer Score - {compScore}";

            // Calculate win percentage correctly
            if (userScore + compScore > 0)
            {
                winPerc = ((double)userScore / (userScore + compScore)) * 100;
            }
            else
            {
                winPerc = 0.0;
            }

            //display win in percentage
            winPercentage.Text = $"Win % - {winPerc:F2}";

        }

        private void winBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
