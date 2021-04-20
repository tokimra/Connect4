using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Player1
    {

        public static string player1;
        public static char red = 'R';
    }
    class Player2
    {

        public static string player2;
        public static char yellow = 'Y';
    }
    class Board
    {
        public static bool gameWin = false;
        public static char currentTurn;
        public char[,] gameBoard = new char[6, 7];

        public void initializeBoard()
        {
            for (int i = 0; i <=5; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    gameBoard[i, j] = 'o';
                }
            }
            Board.currentTurn = Player1.red;
        }
        public void printBoard()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j <= 6; j++)
                {
                    Console.Write(gameBoard[i, j]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
        public bool CheckWin()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (gameBoard[j, i] == Board.currentTurn && gameBoard[j, i + 1] == Board.currentTurn && gameBoard[j, i + 2] == Board.currentTurn && gameBoard[j, i + 3] == Board.currentTurn)
                    {
                        Console.WriteLine("We got a winner!");
                        return true;
                    }
                }
            }

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (gameBoard[j, i] == Board.currentTurn && gameBoard[j + 1, i] == Board.currentTurn && gameBoard[j + 2, i] == Board.currentTurn && gameBoard[j + 3, i] == Board.currentTurn)
                    {
                        Console.WriteLine("We got a winner!");
                        return true;
                    }
                }
            }

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (gameBoard[j, i] == Board.currentTurn && gameBoard[j + 1, i + 1] == Board.currentTurn && gameBoard[j + 2, i + 2] == Board.currentTurn && gameBoard[j + 3, i + 3] == Board.currentTurn)
                    {
                        Console.WriteLine("We got a winner!");
                        return true;
                    }
                }
            }

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 3; j <= 5; j++)
                {
                    if (gameBoard[j, i] == Board.currentTurn && gameBoard[j - 1, i + 1] == Board.currentTurn && gameBoard[j - 2, i + 2] == Board.currentTurn && gameBoard[j - 3, i + 3] == Board.currentTurn)
                    {
                        Console.WriteLine("We got a winner!");
                        return true;
                    }
                }
            }

            return false;
        }
        public char NextTurn()
        {
            if (Board.currentTurn == Player1.red)
            {
                Board.currentTurn = Player2.yellow;
            }
            else
            {
                Board.currentTurn = Player1.red;
            }
            return Board.currentTurn;
        }
        public void ResetBoard()
        {
            initializeBoard();
            gameWin = false;
        }

        public int paintRow(int column)
        {
            int row = -1;
            for (int i = 5; i >= 0; i--)
            {
                if (gameBoard[i, column] == 'o' && i > row)
                {
                    row = i;
                }
            }
            if (row >= 0)
            {
                gameBoard[row, column] = Board.currentTurn;
            }
            else
            {
                ErrorMessage form3 = new ErrorMessage();
                form3.ShowDialog();
            }
            return row;
        }
    }
}
