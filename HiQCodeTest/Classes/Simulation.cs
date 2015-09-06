using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQCodeTest.Classes.Helpers;

namespace HiQCodeTest.Classes
{
    abstract class Simulation
    {
        public CommandsQueue CommandsQueue;
        public SimulationHelper Helper;
        public abstract void Run();
        public abstract int Initialize(string roomSize, string startPosition, string commands, Body entityBody);
    }
}
