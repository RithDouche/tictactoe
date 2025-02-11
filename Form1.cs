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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //decide turn
            DecideTurn();

            //assign click button event
            AssignClickEvents();

            CheckWin();
        }

        private void AssignClickEvents()
        {
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
                if (userTurn)
                {
                    //assign the button to X or O
                    clickedBtn.Text = userSign.ToString();

                    //checkWin

                    //switch to another player
                    compTurn = !compTurn;
                    userTurn = !userTurn;

                    computerMove();
                }
            }

        }

        private void computerMove()
        {
            List<Button> avalaibleBtn = new List<Button>
            {

            };
        }

        private void scoreCount_TextChanged(object sender, EventArgs e)
        {

        }


        private void DecideTurn()
        {
            Random rand = new Random();
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
