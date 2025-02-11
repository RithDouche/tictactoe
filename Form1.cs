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
        //anyone who goes first is assign with X
        private bool compTurn, userTurn;
        private char compSign, userSign;
        List<Button> allBtn;
        Random rand = new Random();
        private bool isBoardFull;

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

            //assign click button event
            AssignClickEvents();
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

            if (clickedBtn != null && string.IsNullOrEmpty(clickedBtn.Text)) {
                if (!isBoardFull && userTurn)
                {
                    //assign the button to X or O
                    clickedBtn.Text = userSign.ToString();

                    //checkWin

                    //switch to another player
                    switchPlay();
                    computerMove();
                }
            }

        }

        private void switchPlay()
        {
            throw new NotImplementedException();
        }

        private void computerMove()
        {
            //add all available button into a list
            List<Button> availableBtn = new List<Button> {};
            foreach (Button button in allBtn)
            {
                if (compTurn && string.IsNullOrEmpty(button.Text)) {
                    availableBtn.Add(button);
                }
            }


            //check is there is any moves left
            if (availableBtn.Count > 0)
            {
                //computer makes a random moves through the availble bottuns count
                Button compChoice = availableBtn[rand.Next(availableBtn.Count)];

                //assign computer sign to the button
                compChoice.Text = compSign.ToString();
            }
            else
            {
                resetGame();
            }
            //check win


            //switch to another player
            switchPlay();
        }

        private void resetGame()
        {
            foreach (Button btn in allBtn)
            {
                btn.Text = "";
            }
            DecideTurn();

        }
        

        private void scoreCount_TextChanged(object sender, EventArgs e)
        {

        }


        private void DecideTurn()
        {
            bool userGoesFirst = rand.Next(2) == 0;

            if (userGoesFirst)
            {
                turn.Text += "User (X)";
                userTurn = true;
                compTurn = false;
                userSign = 'X';
                compSign = 'O';

            }
            else
            {
                turn.Text += "Computer (X)";
                compTurn = true;
                userTurn = false;
                userSign = 'O';
                compSign = 'X';
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
            for (int i = 0; i< 3; i++)
            {
                if (grid[i, 0].Text == grid[i, 1].Text && grid[i, 1].Text == grid[i, 2].Text && !string.IsNullOrEmpty(grid[i, 0].Text))
                {
                    return true;
                }
            }
            // Check winner in column
            for(int j = 0; j < 3; j++)
            {
                if (grid[0,j].Text == grid[1,j].Text && grid[1,j].Text == grid[2,j].Text && !string.IsNullOrEmpty (grid[0,j].Text))
                {
                    return true;
                }
            }

            //Check winner diagonal right
            if (grid[0,0].Text == grid[1,1].Text && grid[1,1].Text == grid[2,2].Text && !string.IsNullOrEmpty(grid[0,0].Text)) 
            {
                return true;
            }

            // Check winner diagonal left
            if (grid[0,2].Text == grid[1,1].Text && grid[1,1].Text == grid[2,0].Text && !string.IsNullOrEmpty(grid[0,2].Text)) 
            {
                return true;
            }

            return false;
        }

    }
}
