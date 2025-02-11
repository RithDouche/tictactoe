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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DecideTurn();
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
                turn.Text += " User";
            }
            else
            {
                turn.Text += " Computer";
            }
        }

    }
}
