using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQCodeTest.Classes.Helpers;

namespace HiQCodeTest.Classes
{
    class CarSimulation : Simulation
    {
        #region Datamembers
        private Room _room;
        private Car _car;
        private bool _isLogging;
        #endregion

        public CarSimulation(bool isLogging) {
            _isLogging = isLogging;
            Helper = new SimulationHelper();
        }

        /// <summary>
        /// Execute the simulation.
        /// </summary>
        public override void Run() {
            Console.WriteLine("Running simulation.");
            bool runSim = true;
            try
            {
                while (runSim)
                {
                    try
                    {
                        CarCommand newCommand = (CarCommand)CommandsQueue.Dequeue();
                        _room.MoveEntity(newCommand);
                    }
                    catch (InvalidOperationException) {
                        runSim = false;
                        Console.WriteLine("Simulation complete, success!\nState:\n" + _car.ToString());
                    }
                    
                }
            }
            catch (EntityHitWallException e) {
                Console.WriteLine("Simulation error, car hit a wall.\nState:\nCrashed, " + ((Car)e.Entity).ToString());
            }
        }

        /// <summary>
        /// Initializes the simulation and its datamembers.
        /// </summary>
        /// <param name="roomSize"></param>
        /// <param name="startPosition"></param>
        /// <param name="commands"></param>
        /// <param name="entityBody"></param>
        /// <returns></returns>
        public override int Initialize(string roomSize, string startPosition, string commands, Body entityBody) {
            if (_isLogging) Console.WriteLine("Initializing simulation.");
            try
            {
                string[] roomData = Helper.Parse(roomSize);
                string[] carData = Helper.Parse(startPosition);
                string[] carCommands = Helper.Parse(commands, true);

                int roomWidth = Int32.Parse(roomData[0]);
                int roomHeight = Int32.Parse(roomData[1]);
                int carStartX = Int32.Parse(carData[0]);
                int carStartY = Int32.Parse(carData[1]);

                _car = new Car(carStartX, carStartY, (CarBody)entityBody, carData[2][0], _isLogging);

                CommandsQueue = new CommandsQueue(carCommands.Length);
                _room = new Room(roomWidth, roomHeight, _car, _isLogging);
                foreach (string command in carCommands)
                {
                    CommandsQueue.Enqueue(new CarCommand(command[0]));
                }
            }
            catch (IsNotEnumException e) {
                Console.WriteLine("Simulation error in Initialize.\n" + e.Message);
                return -1;
            }
            catch (Exception) {
                Console.WriteLine("Simulation error in Initialize.");
                return -1;
            }
            return  0;
        }

    }
}
