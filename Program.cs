using System;

namespace BodyMassIndex


{
    class Program
    {
        static void Main(string[] args)
        {
            int weight, height, BodyMassIndex = 0;
            Console.WriteLine("Enter the weight : ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            height = Convert.ToInt32(Console.ReadLine());

            BodyMassIndex = weight / height;

            Console.WriteLine("Results");
            Console.WriteLine("BodyMassIndex {0}", BodyMassIndex);

            if (BodyMassIndex < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (BodyMassIndex >= 25)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Healthy");
            }



        }
    }
}
