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

            //decide turn
            DecideTurn();
            if (compTurn) { computerMove();}
            
        }

        private void AssignClickEvents()
        {
            // Assign the same event handler to all buttons
            foreach(Button btn in allBtn)
    {
                btn.Click += Button_Click; // Assign the same event to all buttons
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

        private void switchPlay()
        {
            userTurn = !userTurn;
            compTurn = !compTurn;
            turn.Text = userTurn ? $"Turn: User({userSign})" : $"Turn: Computer({compSign})";
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

    }
}
