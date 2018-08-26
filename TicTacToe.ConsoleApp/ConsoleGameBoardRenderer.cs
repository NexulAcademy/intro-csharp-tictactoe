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

            RenderTopCap(board.Grid.Columns);
            for (int r = 0; r < board.Grid.Rows; r++)
            {   //each row is made of 3 lines, marker goes in the second
                RenderRowLine(board, r, 0);
                RenderRowLine(board, r, 1);
                RenderRowLine(board, r, 2);
            }

            Console.WriteLine();
            for (int p = 0; p < board.Players.Count; p++)
            {
                var player = board.Players[p];
                Console.WriteLine(string.Format("{0}: '{1}'", player.Name, player.Marker));
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Renders a row of cells.
        /// </summary>
        /// <remarks>
        /// Notice this method is private.  Its only needed from 'RenderBoard'.
        /// </remarks>
        static private void RenderRowLine(GameBoard board, int row, int line)
        {
            Console.Write("|"); //left border of row
            for (int c = 0; c < board.Grid.Columns; c++)
            {   //each column is 3 rendered rows, marker in middle of middle rendered row
                // Example marker row: " X |"
                if (line == 2)
                {
                    Console.Write("___|");
                }
                else if (line == 1)
                {
                    Console.Write(" ");
                    var cell = board.Grid.Cells.Find(x => x.Row == row && x.Col == c);
                    if (!string.IsNullOrWhiteSpace(cell.Marker))
                    {
                        Console.Write(cell.Marker);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" |");
                }
                else
                {
                    Console.Write("   |");
                }
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Renders the top cap before the first row, 
        /// since each row does not render its own top border.
        /// </summary>
        /// <remarks>
        /// Notice this method is private.  Its only needed from 'RenderBoard'.
        /// </remarks>
        static private void RenderTopCap(int columns)
        {
            Console.Write("_"); //left border of row
            for (int c = 0; c < columns; c++)
            {
                Console.Write("____"); //4 characters per cell
            }
            Console.WriteLine();
        }
    }
}
