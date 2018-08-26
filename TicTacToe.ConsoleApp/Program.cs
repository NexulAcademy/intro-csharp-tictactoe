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
            var board = new GameBoard();
            board.Generate(3, 3);
            return board;
        }
    }
}
