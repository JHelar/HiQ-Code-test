using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes
{
    /// <summary>
    /// Defines the structure of a car body.
    /// </summary>
    class CarBody : Body
    {
        private float _diameter;

        public float Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public double Radius
        {
            get { return _diameter / 2; }
        }

        public CarBody(float width, float height, float length, float diameter) : base(width, height, length) {
            _diameter = diameter;
        }
    }
}
