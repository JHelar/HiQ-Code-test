using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiQCodeTest.Classes.Helpers;

namespace HiQCodeTest.Classes
{
    /// <summary>
    /// An Entity, holds base attributes.
    /// </summary>
    abstract class Entity
    {
        private Position _position;
        private Enums.Heading _orientation;
        private Body _body;

        public Position Position {
            get { return _position; }
            set { _position = value; }
        }

        public Enums.Heading Heading {
            get { return _orientation; }
            set { _orientation = value; }
        }

        public Body Body {
            get { return _body; }
            set { _body = value; }
        }
        
        public abstract void Move(SimulationCommand command);
        public override string ToString() {
            return "Entity, Position: " + _position.ToString() + ", Heading: " + _orientation.ToString() + ".";
        }
    }
}
