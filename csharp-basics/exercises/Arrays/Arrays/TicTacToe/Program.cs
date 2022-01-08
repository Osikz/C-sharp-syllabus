using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            ChooseLocation();

            Console.ReadKey();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("    0   1   2");
            Console.WriteLine(" 0  " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("   ---+---+---");
            Console.WriteLine(" 1  " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("   ---+---+---");
            Console.WriteLine(" 2  " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
        }

        private static void ChooseLocation()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    Console.WriteLine("'X', choose your location (row, column): ");
                    var loc = Console.ReadLine().Trim().ToCharArray();

                    while (board[loc[0] - 48, loc[2] - 48] != ' ')
                    {
                        DisplayBoard();
                        Console.WriteLine("Can't put an 'X' there, choose another open location (row, column): ");
                        loc = Console.ReadLine().Trim().ToCharArray();
                    }

                    board[loc[0] - 48, loc[2] - 48] = 'X';
                }
                else
                {
                    Console.WriteLine("'O', choose your location (row, column): ");
                    var loc = Console.ReadLine().Trim().ToCharArray();

                    while (board[loc[0] - 48, loc[2] - 48] != ' ')
                    {
                        DisplayBoard();
                        Console.WriteLine("Can't put an 'O' there, choose another open location (row, column): ");
                        loc = Console.ReadLine().Trim().ToCharArray();
                    }

                    board[loc[0]-48, loc[2]-48] = 'O';
                }
                DisplayBoard();

                if (CheckWin())
                {
                    Console.WriteLine("The winner is - " + (i % 2 == 0 ? 'X' : 'O') + "!");
                    break;
                }
                else if (i == 8 && !CheckWin())
                {
                    Console.WriteLine("The game is a tie!");
                }
            }
        }

        private static bool CheckWin()
        {
            //ROWS
            if (board[0, 0] == board[0, 1] && 
                board[0, 1] == board[0, 2] &&
                board[0, 2] != ' ' ||
                board[1, 0] == board[1, 1] &&
                board[1, 1] == board[1, 2] &&
                board[1, 2] != ' ' || 
                board[2, 0] == board[2, 1] &&
                board[2, 1] == board[2, 2] &&
                board[2, 2] != ' ')
            {
                return true;
            }

            //COLUMNS
            if (board[0, 0] == board[1, 0] &&
                board[1, 0] == board[2, 0] &&
                board[2, 0] != ' ' ||
                board[0, 1] == board[1, 1] &&
                board[1, 1] == board[2, 1] &&
                board[2, 1] != ' ' ||
                board[0, 2] == board[1, 2] &&
                board[1, 2] == board[2, 2] &&
                board[2, 2] != ' ')
            {
                return true;
            }
           
            //DIAGONALS
            if (board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2] &&
                board[2, 2] != ' ' ||
                board[0, 2] == board[1, 1] &&
                board[1, 1] == board[2, 0] &&
                board[2, 0] != ' ')
            {
                return true;
            }

            return false;
        }
    }
}
