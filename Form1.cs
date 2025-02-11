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
        }

        private void AssignClickEvents()
        {
            // Assign the same event handler to all buttons
            topL.Click += Button_Click;
            topM.Click += Button_Click;
            topR.Click += Button_Click;
            middleL.Click += Button_Click;
            middleM.Click += Button_Click;
            middleR.Click += Button_Click;
            bottomL.Click += Button_Click;
            bottomM.Click += Button_Click;
            bottomR.Click += Button_Click;
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

            }
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

    }
}
