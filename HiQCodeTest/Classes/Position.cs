using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes.Helpers
{   
    /// <summary>
    /// Handles position.
    /// </summary>
    public class Position : Coordinates
    {
        public Position(int x, int y) {
            X = x;
            Y = y;
        }

        public void MovePosition(float x, float y) {
            X += x;
            Y += y;
        }

        public void MovePosition(Coordinates move) {
            X += move.X;
            Y += move.Y;

        }
    }
}
