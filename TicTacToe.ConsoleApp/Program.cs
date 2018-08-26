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

            // TODO: ask for player names

            Console.WriteLine("Press ENTER to begin");
            Console.ReadLine();
        }
        public static GameBoard CreateGameBoard()
        {
            var board = new GameBoard();
            board.Grid = new Grid();

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    var cell = new GridCell();
                    cell.Row = r;
                    cell.Col = c;
                    board.Grid.Cells = new List<GridCell>();
                    board.Grid.Cells.Add(cell);
                }
            }
            return board;
        }
    }
}
