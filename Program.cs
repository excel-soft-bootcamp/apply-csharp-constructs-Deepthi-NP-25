using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMICalculateApp
{
    public enum Options
    {
        ConsoleInput = 1, FileInput

    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 2;
            do
            {
                string message = string.Format("Enter Your Choice {0}->ConsoleIput , {1}->FileIput", Options.ConsoleInput, Options.FileInput);

                string displayMsg = $"Enter Your Choice {(int)Options.ConsoleInput}-->ConsoleInput,{(int)Options.FileInput}-->FileInput";
                Console.WriteLine(displayMsg);
                try
                { 
                    Options choice = (Options)Int32.Parse(Console.ReadLine());
                    if (choice == (Options)1 || choice == (Options)2)
                    {
                        switch (choice)
                        {

                            case Options.ConsoleInput:
                                ConsoleInputReaderLib.ConsoleInputReaderType userEnteredInputs = new ConsoleInputReaderLib.ConsoleInputReaderType();

                                CalculateBMIValueLib.CalculateBMIValueType result = new CalculateBMIValueLib.CalculateBMIValueType();
                                double bmiValue = result.BmiCalculation(userEnteredInputs.GetUserHeight(), userEnteredInputs.GetUserWeight());

                                BMIValueValidateLib.ValidateBMIValueType validate = new BMIValueValidateLib.ValidateBMIValueType();
                                string msg = validate.ValidateBMIValue(bmiValue);

                                ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay(msg);
                                Console.ReadKey();

                                break;

                            case Options.FileInput:
                                string line;
                                System.IO.StreamReader path = new System.IO.StreamReader(@"C:\Users\deepthi.np\source\repos\BMICalculatorApplication\BMICalculatorApplication\bin\Debug\Patient.csv");
                                int ctr = 0;

                                while ((line = path.ReadLine()) != null)
                                {
                                    string[] column = { };
                                    column = line.Split(',');
                                    string name = "";
                                    double height = 0;
                                    double weight = 0;

                                    if (ctr > 0)
                                    {
                                        name = column[0];
                                        height = double.Parse(column[1]);
                                        weight = double.Parse(column[2]);

                                        CalculateBMIValueLib.CalculateBMIValueType result1 = new CalculateBMIValueLib.CalculateBMIValueType();
                                        double bmiValue1 = result1.BmiCalculation(height, weight);

                                        BMIValueValidateLib.ValidateBMIValueType validate1 = new BMIValueValidateLib.ValidateBMIValueType();

                                        String Result = validate1.ValidateBMIValue(bmiValue1);
                                        Console.WriteLine("Name\tHeight\tWeight\tResult\t");
                                        Console.WriteLine(name + "    " + height + "       " + weight + "    " + Result);
                                    }
                                    ctr++;
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("choice should be number");
                }
                --count;
            } while (count > 0);
        }
    }
}





















                    