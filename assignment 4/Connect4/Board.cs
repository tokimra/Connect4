using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    
    class Board
    {
        public static string player1;
        public static string player2;
        public string player;
        public bool CheckWin()
        {
            return true;
        }
        public string NextTurn()
        {
            return player;
        }
        public void ResetBoard()
        {

        }
    }
}
