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
    }
}
