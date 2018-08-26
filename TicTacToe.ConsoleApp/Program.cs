using System;
using System.Collections.Generic;
using TicTacToe.ConsoleApp.Models;

namespace TicTacToe.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            var board = CreateGameBoard();
            // TODO: render the board
            foreach (var cell in board.Grid.Cells)
            {
                Console.WriteLine(string.Format("{0}:{1}", cell.Row, cell.Col));
            }

            // TODO: ask for player names

            Console.WriteLine("Press ENTER to begin");
            Console.ReadLine();
        }
        public static GameBoard CreateGameBoard()
        {
            int cols = 0; int rows = 0;
            while (rows == 0)
            {
                Console.Write("How many rows?:");
                if (!int.TryParse(Console.ReadLine(), out rows))
                {
                    Console.WriteLine("Enter an integer value (Example: 3)");
                }
            }
            while (cols == 0)
            {
                Console.Write("How many columns?:");
                if (!int.TryParse(Console.ReadLine(), out cols))
                {
                    Console.WriteLine("Enter an integer value (Example: 3)");
                }
            }

            var board = new GameBoard();
            board.Generate(rows, cols);
            return board;
        }
    }
}
