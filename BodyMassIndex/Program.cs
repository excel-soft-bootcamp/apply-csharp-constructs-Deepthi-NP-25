using System;

namespace Health


{
    class Program
    {


        static void Main(string[] args)
        {
            int weight, height = 0;
            Console.WriteLine("Enter the weight : ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            height = Convert.ToInt32(Console.ReadLine());

            Program _bmi = new Program();
            bmi = _bmi;
            Console.WriteLine("_bmi is {0} : ");

            if (_bmi < 18.5)
            {
                Console.WriteLine("underweight");
            }
            else if (_bmi >= 25)
            {
                Console.WriteLine("overweight");
            }
            else
            {
                Console.WriteLine("healthy");
            }
        }
    }
}


            

















