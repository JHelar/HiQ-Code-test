using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQCodeTest.Classes;

namespace HiQCodeTest
{
    /// <summary>
    /// HiQ Code Test, 
    /// Made by: John Larsson.
    /// Contact: john.helarsson@gmail.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool isLogging = args.Length > 0 ? (args[0].ToLower().Contains("logg") ? true : false) : false;
        input:
            Console.WriteLine("HiQ Code test.\nSimulator for radio controlled cars.\nMade by: John Larsson");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Room size (width height): ");
            string roomSize = Console.ReadLine();

            Console.WriteLine("Start position and heading (x y (n/s/e/w)): ");
            string startPosition = Console.ReadLine();

            Console.WriteLine("Simulation car commands (f/b/r/l): ");
            string commands = Console.ReadLine();

            Console.WriteLine("\"Any\" key to run simulation.");
            Console.ReadKey();

            Console.Clear();
            CarSimulation sim = new CarSimulation(isLogging);

            Console.WriteLine("-------------------------");
            int status = sim.Initialize(roomSize, startPosition, commands, new CarBody(1, 1, 1, 1));
            if (status == -1) {
                Console.WriteLine("Try again.");
                Console.WriteLine("-------------------------");
                goto input;
            }
            else
                sim.Run();

            Console.WriteLine("-------------------------");
            Console.WriteLine("\"Any\" key to exit.");
            Console.ReadKey();
        }
    }
}
