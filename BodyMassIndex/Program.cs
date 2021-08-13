using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Health
{
    class Program
    {
        static void Main(string[] args)
        {
            float height = ConsoleUserInputReader.GetUserHeight();
            float weight = ConsoleUserInputReader.GetUserWeight();

            float bmiValue = CalculateBMIValue.BmiCalculation(height, weight);

            string message = CheckCondition.ValidateBMIValue(bmiValue);

            ConsoleDisplayType.ConsoleDisplay(message);
        }
    }
}
                    
    





















