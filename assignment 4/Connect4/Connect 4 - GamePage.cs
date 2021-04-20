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
        public void determineColor(int column)
        {

            int row = board.paintRow(column);
            if (row >= 0)
            {
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

        Color[,] bgColors = new Color[6, 7]
        {
            {SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  }
        };

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
            determineColor(btnColumn1.TabIndex);
        }

        private void btnColumn2Press(object sender, EventArgs e)
        {
            determineColor(btnColumn2.TabIndex);
        }

        private void btnColumn3Press(object sender, EventArgs e)
        {
            determineColor(btnColumn3.TabIndex);
        }

        private void btnColumn4Press(object sender, EventArgs e)
        {
            determineColor(btnColumn4.TabIndex);
        }

        private void btnColumn5Press(object sender, EventArgs e)
        {
            determineColor(btnColumn5.TabIndex);
        }

        private void btnColumn6Press(object sender, EventArgs e)
        {
            determineColor(btnColumn6.TabIndex);
        }

        private void btnColumn7Press(object sender, EventArgs e)
        {
            determineColor(btnColumn7.TabIndex);
        }

        private void tableCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Row, e.Column]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
    }
}
