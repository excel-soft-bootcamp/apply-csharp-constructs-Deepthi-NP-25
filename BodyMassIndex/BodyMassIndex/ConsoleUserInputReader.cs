using System;
using System.Collections.Generic;
using System.Text;

namespace Health
{
    class ConsoleUserInputReader
    {
        public static int GetUserHeight()
        {
            ConsoleDisplayType.ConsoleDisplay("Enter your height in meter:");
            string heightInMeter = Console.ReadLine();
            int height = int.Parse(heightInMeter);
            return height;
        }

        public static int GetUserWeight()
        {
            ConsoleDisplayType.ConsoleDisplay("Enter your weight in kg:");
            string weightInKG = Console.ReadLine();
            int weight = int.Parse(weightInKG);
            return weight;
        }
    }
}
