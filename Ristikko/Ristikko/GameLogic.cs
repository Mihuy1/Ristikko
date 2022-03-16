using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ristikko
{
    public class GameLogic
    {
        public string CurrentPlayer { get; set; } = X;

        private const string X = "X";
        private const string O = "O";
        private string[,] Board = new string[3, 3];

        public void SetNextPlayer () 
        { 
            if (CurrentPlayer == X) 
            {
                CurrentPlayer = O;
            } else 
            {
                CurrentPlayer = X;
            }
        }

        public bool PlayerWin()
        {
            return true;
        }

        internal void UpdateBoard(Position position, string value)
        {
            Board[position.x, position.y] = value;
        }
    }


}
