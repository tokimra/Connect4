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
    public partial class Form2 : Form
    {

        Board board = new Board();
        private void basicNotion()
        {
            

            board.printBoard();
            if (board.CheckWin() == true)
            {
                CongratulationMessage form4 = new CongratulationMessage();
                this.Visible = false;
                form4.ShowDialog();
                System.Windows.Forms.Application.Exit();
            }
            board.NextTurn();
        }
        public Form2()
        {
            InitializeComponent();
            board.initializeBoard();
        }

        private void menuNewGamePress(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }

        private void menuQuitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnColumn1Press(object sender, EventArgs e)
        {
            board.placeToken(btnColumn1.TabIndex);
            basicNotion();
        }

        private void btnColumn2Press(object sender, EventArgs e)
        {

            board.placeToken(btnColumn2.TabIndex);
            basicNotion();
        }

        private void btnColumn3Press(object sender, EventArgs e)
        {

            board.placeToken(btnColumn3.TabIndex);
            basicNotion();
        }

        private void btnColumn4Press(object sender, EventArgs e)
        {

            board.placeToken(btnColumn4.TabIndex);
            basicNotion();
        }

        private void btnColumn5Press(object sender, EventArgs e)
        {

            board.placeToken(btnColumn5.TabIndex);
            basicNotion();
        }

        private void btnColumn6Press(object sender, EventArgs e)
        {

            board.placeToken(btnColumn6.TabIndex);
            basicNotion();
        }

        private void btnColumn7Press(object sender, EventArgs e)
        {

            board.placeToken(btnColumn7.TabIndex);
            basicNotion();
        }
    }
}
