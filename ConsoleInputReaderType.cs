using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputReaderLib
{
    public class ConsoleInputReaderType
    {
        public double GetUserHeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your height in meter:");
            double height = double.Parse(Console.ReadLine());
            return height;
        }

        public double GetUserWeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your weight in kg:");
            double weight = double.Parse(Console.ReadLine());
            return weight;
        }
    }
}

        