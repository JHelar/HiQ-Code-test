using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HiQCodeTest.Classes.Helpers;

namespace HiQCodeTest.Classes
{
    /// <summary>
    /// Car class, inherits from entity.
    /// </summary>
    class Car : Entity
    {
        #region Datamembers
        private Coordinates _forward;
        private Coordinates _backward;
        private bool _isLogging;
        #endregion
        /// <summary>
        /// Construct for a Car.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        /// <param name="direction"></param>
        public Car(int x, int y, CarBody body, char heading, bool isLogging)
        {
            Body = body;
            Position = new Position(x, y);
            _forward = new Coordinates();
            _backward = new Coordinates();
            _isLogging = isLogging;

            Heading = (Enums.Heading)heading;
            SetForwardBackward();
        }
        /// <summary>
        /// Move the position or the heading of the car depending on current direction.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void Move(SimulationCommand command){

            if (command.GetType() == typeof(CarCommand)){
                CarCommand carCommand = (CarCommand)command;
                if (_isLogging) Console.WriteLine("Car: Moving " + carCommand.Direction.ToString());
                switch (carCommand.Direction)
                {
                    case Enums.Direction.forward:
                        this.Position.MovePosition(_forward.X, _forward.Y);
                        break;
                    case Enums.Direction.back:
                        this.Position.MovePosition(_backward.X, _backward.Y);
                        break;
                    case Enums.Direction.left:
                        TurnLeft();
                        break;
                    case Enums.Direction.right:
                        TurnRight();
                        break;
                    default:
                        throw new IsNotEnumException("Car: " + "\"" + Convert.ToChar(carCommand.Direction) + "\"" + " is not a valid command.");
                }
            }
            else {
                throw new IsNotCarException("Command given is not of type CarCommand.");
            }
        }

        public override string ToString()
        {
            return "Car: Position: " + Position.ToString() + ", Heading: " + Heading.ToString() + ".";
        }
        #region Private methods
        private void TurnLeft() {
            switch (Heading) {
                case Enums.Heading.north:
                    Heading = Enums.Heading.west;
                    break;
                case Enums.Heading.south:
                    Heading = Enums.Heading.east;
                    break;
                case Enums.Heading.east:
                    Heading = Enums.Heading.north;
                    break;
                case Enums.Heading.west:
                    Heading = Enums.Heading.south;
                    break;
                default:
                    throw new IsNotEnumException("Car: " + "\"" + Convert.ToChar(Heading) + "\"" + " is not a valid heading.");
            }
            SetForwardBackward();
        }

        private void TurnRight() {
            switch (Heading) {
                case Enums.Heading.north:
                    Heading = Enums.Heading.east;
                    break;
                case Enums.Heading.south:
                    Heading = Enums.Heading.west;
                    break;
                case Enums.Heading.east:
                    Heading = Enums.Heading.south;
                    break;
                case Enums.Heading.west:
                    Heading = Enums.Heading.north;
                    break;
                default:
                    throw new IsNotEnumException("Car: " + "\"" + Convert.ToChar(Heading) + "\"" + " is not a valid heading.");
            }
            SetForwardBackward();
        }

        private void SetForwardBackward() {
            CarBody body = (CarBody)Body;
            switch (Heading) {
                case Enums.Heading.north:
                    _forward.Set(0, body.Diameter);
                    _backward.Set(0, -body.Diameter);
                    break;
                case Enums.Heading.south:
                    _forward.Set(0, -body.Diameter);
                    _backward.Set(0, body.Diameter);
                    break;
                case Enums.Heading.east:
                    _forward.Set(body.Diameter, 0);
                    _backward.Set(-body.Diameter, 0);
                    break;
                case Enums.Heading.west:
                    _forward.Set(-body.Diameter, 0);
                    _backward.Set(body.Diameter, 0);
                    break;
                default:
                    throw new IsNotEnumException("Car: " + "\"" + Convert.ToChar(Heading) + "\"" + " is not a valid heading.");
            }
        }
#endregion
    }
}
