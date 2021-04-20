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
        //Initialize form
        public Form1()
        {
            InitializeComponent();
        }
        //Load form
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //Move players to next page if button is pressed
        private void btnDonePress(object sender, EventArgs e)
        {
            //Trim player names
            Player1.player1 = txtBoxPlayer1.Text.Trim();
            Player2.player2 = txtBoxPlayer2.Text.Trim();
            //Check to see if there are empty values after trimming names
            if (Player1.player1.Equals("") || Player2.player2.Equals(""))
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
        //Exit application if button is pressed
        private void menuQuitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
