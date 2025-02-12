//////////////////////////////////////////
/// Name                Date        Description
/// Sotharith Sieng     2/7/25     Created the initial framework for Tic-Tac-Toe game, set up basic UI.
/// Harmansb            2/7/25     Added button functionality for Tic-Tac-Toe grid.
/// Sotharith Sieng     2/8/25     Implemented user input handling and basic game state management.
/// Harmansb            2/8/25     Added event handling for button clicks, checked for winner conditions.
/// Sotharith Sieng     2/9/25     Added functionality for computer moves with random selections and who goes first selection
/// Harmansb            2/9/25     Increased table size to include additional buttions and text boxes (Turn, Winner, New Game, Stop Game)
/// Sotharith Sieng     2/10/25    Created a score tracking system to monitor user and computer scores.
/// Harmansb            2/10/25    Updated the game UI to show win percentages and scores dynamically.
/// Sotharith Sieng     2/12/25    Created Tic-Tac-Toe game logic, added user and computer moves, score tracking, and game reset functionality.
/// Harmansb            2/12/25    Fixed reset game point tracking, gameStopped flag, and updated resetGame method to ensure accurate game resets.
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
        // Boolean to store if it is User's turn or Computer's turn
        private bool compTurn, userTurn;

        // Stores player's sign (X for user, O for computer)
        private char compSign, userSign;

        // List to store all the buttons for the game grid
        List<Button> allBtn;

        // Random number generator for computer moves
        Random rand = new Random();

        // Score counters for both players
        Int32 compScore = 0;
        Int32 userScore = 0;

        // User win percentage
        double winPerc = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add all the buttons into the list for easy access
            allBtn = new List<Button>
            {
                topR, topM, topL, middleR, middleM, middleL, bottomR, bottomM, bottomL
            };

            // Assign reset button functionality and update score on form load
            UpdateScores();
            // Assign click event handlers for each button
            AssignClickEvents();
            // Decide who goes first (User or Computer)
            DecideTurn();
        }

        private void AssignClickEvents()
        {
            // List of buttons for the Tic-Tac-Toe grid
            List<Button> buttons = new List<Button> { topL, topM, topR, middleL, middleM, middleR, bottomL, bottomM, bottomR };

            // Assign Button_Click method to each button to handle user clicks
            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        // Handle user click event for each button
        private void Button_Click(object sender, EventArgs e)
        {
            // Prevent moves if the game is stopped
            if (gameStopped) return;

            // Button variable to store what button the user clicked
            Button clickedBtn = sender as Button;

            // Check if the button exists and is empty
            if (clickedBtn != null && string.IsNullOrEmpty(clickedBtn.Text))
            {
                // Check if it's the user's turn and there are available moves
                if (userTurn && checkAvailable().Count > 0)
                {
                    // Assign the button to X or O with the user's sign
                    clickedBtn.Text = userSign.ToString();

                    // Check if the user wins after the move
                    if (CheckWin())
                    {
                        // Display winner message and update score
                        winBox.Text = "Winner: " + Environment.NewLine + "User Wins!";
                        userScore += 1;
                        UpdateScores();
                        // End the turn
                        endTurn();
                        return;
                    }
                    else if (checkAvailable().Count == 0)
                    {
                        // If the board is full and no winner, it's a draw
                        winBox.Text = "It's a draw!";
                        endTurn();
                        return;
                    }

                    // Switch to the next player (computer's turn)
                    switchPlay();
                }
            }
        }

        // Switch turns between user and computer
        private void switchPlay()
        {
            compTurn = !compTurn;
            userTurn = !userTurn;

            // If it's the computer's turn, make a move
            if (compTurn) { computerMove(); }
        }

        // Handle computer's move logic
        private void computerMove()
        {
            // Get a list of available buttons for the computer to choose from
            List<Button> availableBtn = checkAvailable();

            // Check if there are any available moves
            if (availableBtn.Count > 0)
            {
                // Choose a random button from available moves
                Button compChoice = availableBtn[rand.Next(availableBtn.Count)];

                // Assign computer's sign to the selected button
                compChoice.Text = compSign.ToString();

                // Check if the computer wins after its move
                if (CheckWin())
                {
                    // Display winner message and update score
                    winBox.Text = "Winner:" + Environment.NewLine + "Computer Wins!";
                    compScore += 1;
                    UpdateScores();
                    return;
                }
                else if (checkAvailable().Count == 0)
                {
                    // If no available moves and no winner, it's a draw
                    winBox.Text = "It's a draw!";
                    endTurn();
                    return;
                }
            }

            // Switch to the next player (user's turn)
            switchPlay();
        }

        // Flag to track whether the game has stopped or not
        private bool gameStopped = false;

        // Stop or resume the game when the stop game button is clicked
        private void stopGame_Click(object sender, EventArgs e)
        {
            // Toggle if the game is stopped or not
            gameStopped = !gameStopped;

            // Change the button text based on the game state
            if (gameStopped)
            {
                stopGame.Text = "Resume Game";
            }
            else
            {
                stopGame.Text = "Stop Game";
            }
        }

        // End both turns (no more moves can be made)
        private void endTurn()
        {
            compTurn = false;
            userTurn = false;
        }

        // Check if there is an available button left (no symbol in it)
        private List<Button> checkAvailable()
        {
            // Create a list of available buttons
            List<Button> availableBtn = new List<Button>();

            // Loop through all the buttons and check for empty ones
            foreach (Button button in allBtn)
            {
                if (string.IsNullOrEmpty(button.Text))
                {
                    availableBtn.Add(button);
                }
            }
            return availableBtn;
        }

        // Reset the game, clearing all the buttons and resetting the score
        private void resetGame()
        {
            // Go through each button and remove its text
            //add score to computer if the player moves and resets game
            if (checkAvailable().Count < 8 && checkAvailable().Count > 0)
            {
                if (!CheckWin())
                {
                    compScore++;
                }
            }

            foreach (Button btn in allBtn)
            {
                btn.Text = "";
            }

            // Update score display
            UpdateScores();
            // Decide who goes first after resetting the game
            DecideTurn();
        }

        // Decide who goes first (user or computer) and initialize the turn
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

                // If it's computer's turn, make a move immediately
                computerMove();
            }
        }

        // Check if a player has won (3 in a row horizontally, vertically, or diagonally)
        private bool CheckWin()
        {
            Button[,] grid = new Button[,]
            {
                {topL, topM, topR},
                {middleL, middleM, middleR},
                {bottomL, bottomM, bottomR}
            };

            // Check winner in rows
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0].Text == grid[i, 1].Text && grid[i, 1].Text == grid[i, 2].Text && !string.IsNullOrEmpty(grid[i, 0].Text))
                {
                    return true;
                }
            }

            // Check winner in columns
            for (int j = 0; j < 3; j++)
            {
                if (grid[0, j].Text == grid[1, j].Text && grid[1, j].Text == grid[2, j].Text && !string.IsNullOrEmpty(grid[0, j].Text))
                {
                    return true;
                }
            }

            // Check winner diagonal right
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

        // Reset the game when the new game button is clicked
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            resetGame();
            winBox.Text = "Winner:";
        }

        // Update the scores and display win percentage
        private void UpdateScores()
        {
            userSC.Text = $"User score - {userScore}";
            computerSC.Text = $"Computer Score - {compScore}";

            // Calculate win percentage
            if (userScore + compScore > 0)
            {
                winPerc = ((double)userScore / (userScore + compScore)) * 100;
            }
            else
            {
                winPerc = 0.0;
            }

            // Update the win percentage display
            winPercentage.Text = $"Win % - {winPerc:F2}";
        }

        private void winBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
