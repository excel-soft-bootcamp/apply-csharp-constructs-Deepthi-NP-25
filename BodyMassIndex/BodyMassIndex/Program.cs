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
            Console.WriteLine("BMI CalculatorApp");
            do
            {
                Console.WriteLine("Enter the Option");
                Console.WriteLine("1. Calculate method");
                Console.WriteLine("2. .csv read method");
                try
                {
                    int Option = Int32.Parse(Console.ReadLine());

                    if (Option == 1)
                    {
                        float height = ConsoleUserInputReader.GetUserHeight();
                        float weight = ConsoleUserInputReader.GetUserWeight();

                        float bmiValue = CalculateBMIValue.BmiCalculation(height, weight);

                        string message = CheckCondition.ValidateBMIValue(bmiValue);

                        ConsoleDisplayType.ConsoleDisplay(message);
                    }
                    else if (Option == 2)
                    {
                        try
                        {
                            String st = File.ReadAllText("C:\\Patientdetails\\Patient.csv");
                            Console.WriteLine(st);
                        }

                        catch(Exception ex)
                        {
                            Console.WriteLine("File not found");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Option must be a Number");
                }
            } while (true);
              
            
        }
    }
}

            
        
    





















