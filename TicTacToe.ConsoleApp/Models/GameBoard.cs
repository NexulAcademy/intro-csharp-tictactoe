using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.ConsoleApp.Models
{
    public class GameBoard
    {
        public string Message { get; set; }

        public Grid Grid { get; set; }

        public List<Player> Players { get; set; }

        public GameBoard()
        {
            Grid = new Grid(0, 0);
            Players = new List<Player>();
        }

        public void Generate(int rows, int cols)
        {
            Grid = new Grid(rows, cols);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    var cell = new GridCell();
                    cell.Row = r;
                    cell.Col = c;
                    Grid.Cells.Add(cell);
                }
            }
        }

        public bool Move(Player player, int row, int col)
        {
            if (row < 1
                || col < 1
                || row > Grid.Rows
                || col > Grid.Columns)
            {
                Message = string.Format("Invalid coordinate: {0},{1}", row, col);
                return false;
            }

            int iRow = row - 1; int iCol = col - 1; //get to 0-based index

            var cell = Grid.Cells.Find(c => c.Row == iRow && c.Col == iCol);
            if (cell == null)
            {
                Message = string.Format("Invalid Cell: {0},{1}", row, col);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(cell.Marker))
            {
                Message = string.Format("Cell already claimed by '{2}': {0},{1}", row, col, cell.Marker);
                return false;
            }

            cell.Marker = player.Marker;
            return true;
        }
    }
}
