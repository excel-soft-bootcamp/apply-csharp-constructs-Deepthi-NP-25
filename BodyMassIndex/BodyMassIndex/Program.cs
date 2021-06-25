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

            BodyMassIndex obj = new BodyMassIndex();
            obj.SetHeight = height;
            obj.SetWeight = weight;
            int result = obj.Calculator();
            Console.WriteLine("result is : " +result);
            Evaluate data = new Evaluate();
            data.details(result);
        }
    }
}


            
           

            

















