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
        
        
        public CongratulationMessage()
        {
            InitializeComponent();
            if(Board.currentTurn == Player1.red)
            {
                lblPlayer.Text = Player1.player1;
            }
            else
            {
                lblPlayer.Text = Player2.player2;
            }
        }

        private void btnPlayAgainPress(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }

        private void btnExitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
