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
    public partial class WelcomePage : Form
    {
        //Initialize form
        public WelcomePage()
        {
            InitializeComponent();
        }
        //Move players to next page after button is pressed
        private void btnNextPress(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }
        //Exit application if button is pressted
        private void menuQuitPress(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
