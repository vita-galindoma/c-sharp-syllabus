using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char _currentPlayer = 'O';

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            MakeAMove();
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
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static void MakeAMove()
        {
            Console.WriteLine("Enter coordinate on x axys - 0, 1 or 2");
            int inputX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate on y axys - 0, 1, or 2");
            int inputY = Convert.ToInt32(Console.ReadLine());

            if (board[inputY, inputX] != ' ')
            {
                _currentPlayer = _currentPlayer == 'X' ? 'X' : 'O';
            }
            else
            {
                _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
            }

            board[inputY, inputX] = _currentPlayer;
            DisplayBoard();
            CheckAWin();
        }

        private static void CheckAWin()
        {
            if ((board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
                || (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
                || (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
                || (board[2, 2] == 'X' && board[1, 1] == 'X' && board[0, 0] == 'X')
                || (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
                || (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
                || (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
                || (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X'))
            {
                Console.WriteLine("X won");
                Console.ReadKey();
            }
            else if (((board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
                      || (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
                      || (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
                      || (board[2, 2] == 'O' && board[1, 1] == 'O' && board[0, 0] == 'O')
                      || (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
                      || (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
                      || (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
                      || (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O'))
            )
            {
                Console.WriteLine("O won");
                Console.ReadKey();
            }
            else
            {
                CheckATie();
            }
        }

        private static void CheckATie()
        {
            int freeSpots = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != ' ')
                    {
                        freeSpots--;
                        if (freeSpots == 0)
                        {
                            Console.WriteLine("It's a Tie!");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        MakeAMove();
                    }
                }
            }
        }
    }
}
