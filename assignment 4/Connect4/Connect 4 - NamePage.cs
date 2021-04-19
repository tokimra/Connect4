// Name: Thomas Truong
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDonePress(object sender, EventArgs e)
        {
            Board.player1 = txtBoxPlayer1.Text.Trim();
            Board.player2 = txtBoxPlayer2.Text.Trim();
            if (Board.player1.Equals("") || Board.player2.Equals(""))
            {
                lblInvalid.Text = "Names cannot be empty values! Try again.";
            }
            else
            {
                Form2 form2 = new Form2();
                this.Visible = false;
                form2.ShowDialog();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void menuQuitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
