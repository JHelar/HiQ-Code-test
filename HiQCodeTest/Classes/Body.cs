using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes
{
    /// <summary>
    /// Base class body, defines height and width.
    /// </summary>
    public abstract class Body
    {
        #region Datamembers
        private float _width;
        private float _height;
        private float _length;
        #region Accessors
        public float Width {
            get { return _width; }
            set { _width = value; }
        }

        public float Height {
            get { return _height; }
            set { _height = value; }
        }

        public float Length {
            get { return _length; }
            set { _length = value; }
        }
        #endregion
        #endregion
        public Body(float width, float height, float length) {
            _width = width;
            _height = height;
            _length = length;
        }
    }
}
