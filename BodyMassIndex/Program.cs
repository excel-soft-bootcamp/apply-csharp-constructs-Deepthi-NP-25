using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health
{
    class Program
    {
        static void Main(string[] args)
        {
            Displaymessage display = new Displaymessage();
            int height = display.SetHeight();
            int weight = display.SetWeight();

            Calculate value = new Calculate();
            value.SetHeight = height;
            value.SetWeight = weight;
            int result = value.CalculateResult();

            Checkcondition value2 = new Checkcondition();
            value2.BMIValidate(result);

            Console.ReadLine();
        }
    }
}























