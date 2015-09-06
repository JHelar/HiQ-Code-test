using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes
{
    class CommandsQueue : Queue<SimulationCommand>
    {
        public CommandsQueue(int size) : base(size) { }
    }
}
