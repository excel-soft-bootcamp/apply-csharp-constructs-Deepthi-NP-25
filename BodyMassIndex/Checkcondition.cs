using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health
{
    class Checkcondition
    {
        Displaymessage condition = new Displaymessage();
        public void BMIValidate(int bmivalue)
        {
            if (bmivalue < 18.5)
            {
                condition.Underweight();
                
            }
            else if (bmivalue > 25)
            {
                condition.Overweight();
            }
           else 
            {
                condition.Normal();
            }
        }
    }
}


