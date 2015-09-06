using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes.Helpers
{
    class SimulationHelper
    {
        /// <summary>
        /// Parses a string of simulation commands or other data.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="isCommand"></param>
        /// <returns></returns>
        public string[] Parse(string str, bool isCommand = false) {
            str = str.ToUpper();

            string[] returnArray = null;
            if (isCommand){
                returnArray = new string[str.Length];
                for (int i = 0; i < str.Length; i++) {
                    returnArray[i] = str[i].ToString();
                }
            }
            else {
                returnArray = str.Split(' ');
            }
            return returnArray;
        }
    }
}
