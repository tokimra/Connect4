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
        //Create board
        Board board = new Board();
        //This will go through notion of printing boar onto console and checking win conditions. 
        private void basicNotion()
        {
            board.printBoard();
            //If conditions are met then display congratulations message
            if (board.CheckWin() == true)
            {
                CongratulationMessage form4 = new CongratulationMessage();
                this.Visible = false;
                form4.ShowDialog();
                System.Windows.Forms.Application.Exit();
            }
            //Move current player to next player
            board.NextTurn();
        }
        //This will color the cell in the table in respect to player
        public void determineColor(int column)
        {
            //This will determind if the column is full
            int row = board.paintRow(column);
            if (row >= 0)
            {
                //This will change the cell color in respect to player
                if (Board.currentTurn == Player1.red)
                {
                    bgColors[row, column] = Color.Red;
                    tableLayoutPanel1.Refresh();
                    basicNotion();
                }
                else
                {
                    bgColors[row, column] = Color.Yellow;
                    tableLayoutPanel1.Refresh();
                    basicNotion();
                }
            }
        }
        //Creating an array of color for the table
        Color[,] bgColors = new Color[6, 7]
        {
            {SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  }
        };
        //Initialize board
        public Form2()
        {
            InitializeComponent();
            board.initializeBoard();
        }
        //This will navigate players back to name page if button is pressed
        private void menuNewGamePress(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }
        //This will quit the application if button is pressed
        private void menuQuitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn1Press(object sender, EventArgs e)
        {
            determineColor(btnColumn1.TabIndex);
        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn2Press(object sender, EventArgs e)
        {
            determineColor(btnColumn2.TabIndex);
        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn3Press(object sender, EventArgs e)
        {
            determineColor(btnColumn3.TabIndex);
        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn4Press(object sender, EventArgs e)
        {
            determineColor(btnColumn4.TabIndex);
        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn5Press(object sender, EventArgs e)
        {
            determineColor(btnColumn5.TabIndex);
        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn6Press(object sender, EventArgs e)
        {
            determineColor(btnColumn6.TabIndex);
        }
        //This will color the appropriate cell in respect to player and place token on board
        private void btnColumn7Press(object sender, EventArgs e)
        {
            determineColor(btnColumn7.TabIndex);
        }
        //This will draw background of cell
        private void tableCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Row, e.Column]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
    }
}
