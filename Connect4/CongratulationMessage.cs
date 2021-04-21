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
    public partial class CongratulationMessage : Form
    {
        //Displays Congratulations message if win condition met
        public CongratulationMessage()
        {
            InitializeComponent();
            //Displays the name of the player that wins
            if(Board.currentTurn == Player1.red)
            {
                lblPlayer.Text = Player1.player1;
            }
            else
            {
                lblPlayer.Text = Player2.player2;
            }
        }
        //Button will return to page to enter names if players want to play again
        private void btnPlayAgainPress(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }
        //Button will exit if players do not want to continue playing
        private void btnExitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
