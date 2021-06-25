using System;
using System.Collections.Generic;
using System.Text;

namespace Health
{
    class Evaluate
    {
       public void details(int bmi)
        {
            if ( bmi < 18.5 )
            {
                Console.WriteLine("underweight");
            }
            else if ( bmi >= 25 )
            {
                Console.WriteLine("overweight");
            }
            else
            {
                Console.WriteLine("Healthy");
            }
        }
            
    }
}
