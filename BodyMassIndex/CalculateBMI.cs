using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndex
{
    class CalculateBMI
    {
        int weight, height, BodyMassIndex = 0;
        
        public int Getweight()
        {
            return weight;
        }
        public int Getheight()
        {
            return height;
        }
        BodyMassIndex = weight / height;
        Console.WriteLine("BodyMassIndex is : ");

        if (BodyMassIndex< 18.5)
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





