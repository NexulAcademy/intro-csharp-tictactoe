using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.ConsoleApp.Models;

namespace TicTacToe.ConsoleApp
{
    public static class ConsoleGameBoardRenderer
    {
        static public void RenderBoard(GameBoard board)
        {
            Console.Clear();
            Console.WriteLine();
            foreach (var cell in board.Grid.Cells)
            {
                Console.WriteLine(string.Format("{0}:{1}", cell.Row, cell.Col));
            }
            // TODO: render the cells line by line

            Console.WriteLine();
            for (int p = 0; p < board.Players.Count; p++)
            {
                var player = board.Players[p];
                Console.WriteLine(string.Format("{0}: '{1}'", player.Name, player.Marker));
            }
            Console.WriteLine();
        }
    }
}
