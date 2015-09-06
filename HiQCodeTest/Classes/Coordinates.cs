using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes
{
    /// <summary>
    /// Helper class to hold two coordinates.
    /// </summary>
    public class Coordinates
    {
        private float _x;
        private float _y;

        public float X {
            get { return _x; }
            set { _x = value; }
        }
        public float Y {
            get { return _y; }
            set { _y = value; }
        }

        public void Set(float x, float y) {
            this._x = x;
            this._y = y;
        }

        public Coordinates(float x, float y) {
            _x = x;
            _y = y;
        }

        public Coordinates() {}

        public override string ToString() {
            return "[" + _x.ToString() + "," + _y.ToString() +"]";
        }
    }
}
