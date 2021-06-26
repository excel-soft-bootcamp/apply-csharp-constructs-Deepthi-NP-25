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

            Calculate obj = new Calculate();
            obj.SetHeight = height;
            obj.SetWeight = weight;
            int result = obj.CalculateResult();

            Checkcondition obj2 = new Checkcondition();
            obj2.BMIValidate(result);

            Console.ReadLine();
        }
    }
}























