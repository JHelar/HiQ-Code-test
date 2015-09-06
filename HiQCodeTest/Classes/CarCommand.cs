using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQCodeTest.Classes.Helpers;

namespace HiQCodeTest.Classes
{
    /// <summary>
    /// A CarComand defines one command for a car.
    /// </summary>
    class CarCommand : SimulationCommand
    {
        private Enums.Direction _direction;

        public Enums.Direction Direction {
            get { return _direction; }
            set { _direction = value; }
        }

        public CarCommand(Enums.Direction direction) {
            _direction = direction; 
        }

        public CarCommand(char command) {
            var dir = (Enums.Direction)command;
            switch (dir) {
                case Enums.Direction.forward:
                case Enums.Direction.back:
                case Enums.Direction.left:
                case Enums.Direction.right:
                    _direction = dir;
                    break;
                default:
                    throw new IsNotEnumException("CarCommand: " + "\"" + command + "\"" + " is not a valid Car command.");
            }   
        }
    }
}
