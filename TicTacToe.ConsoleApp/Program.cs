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
            ConsoleGameBoardRenderer.RenderBoard(board);

            SetupPlayers(board);
            ConsoleGameBoardRenderer.RenderBoard(board);

            Console.WriteLine("Press ENTER to begin");
            Console.ReadLine();

            GameLoop(board);
        }

        public static void GameLoop(GameBoard board)
        {
            while (true)
            {
                for (var p = 0; p < board.Players.Count; p++)
                {
                    var player = board.Players[p];
                    // TODO: prompt the player to pick a move
                }
                ConsoleGameBoardRenderer.RenderBoard(board);

                Console.WriteLine("Quit? (y | n)");
                var key = Console.ReadKey();
                if (key.KeyChar.ToString().ToLower() == "y")
                    break; //some way to exit the game other than closing window.
            }
        }

        public static GameBoard CreateGameBoard()
        {
            int cols = PromptInteger("How many rows?:");
            int rows = PromptInteger("How many columns?:");

            var board = new GameBoard();
            board.Generate(rows, cols);
            return board;
        }

        public static void SetupPlayers(GameBoard board)
        {
            var count = PromptInteger("How many players?");
            for (int p = 0; p < count; p++)
            {
                Console.Write(string.Format("Name of player {0}: ", p + 1));
                var name = Console.ReadLine();
                var marker = "";
                while (string.IsNullOrWhiteSpace(marker))
                {
                    Console.Write(name + "'s marker: ");
                    marker = (Console.ReadKey().KeyChar).ToString();
                }
                Console.WriteLine();
                board.Players.Add(new Player { Name = name, Marker = marker });
            }
        }

        private static int PromptInteger(string message)
        {
            int x = 0;
            while (x == 0)
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Enter an integer value (Example: 3)");
                }
            }
            return x;
        }
    }
}
