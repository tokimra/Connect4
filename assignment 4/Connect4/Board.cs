using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    /*
     * Thomas Truong
     * CSC 339 -02
     * 04/20/2021
     */

    //Player contains name and represented by a char
    class Player1
    {
        public static string player1;
        public static char red = 'R';
    }
    //Player contains name and represented by a char
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
        //Initialization of board
        public void initializeBoard()
        {
            for (int i = 0; i <=5; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    gameBoard[i, j] = 'o';
                }
            }
            //Starts our with Player 1
            Board.currentTurn = Player1.red;
        }
        //Print board onto console
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
        //Checks win conditions and returns true if conditions met
        public bool CheckWin()
        {
            //Checks for vertical win condition
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
            //Checks for horizontal win condition
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
            //Checks for diagonal win condition
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
            //Checks for alternative diagonal win condition
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
            //Returns false if no win conditions are met
            return false;
        }
        //Changes current player to next player
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
        //Resets board
        public void ResetBoard()
        {
            initializeBoard();
            gameWin = false;
        }
        //Places token on board in respect to player color and returns the row to place token
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
            //Places token on board
            if (row >= 0)
            {
                gameBoard[row, column] = Board.currentTurn;
            }
            //Displays error message if columns are full
            else
            {
                ErrorMessage form3 = new ErrorMessage();
                form3.ShowDialog();
            }
            return row;
        }
    }
}
