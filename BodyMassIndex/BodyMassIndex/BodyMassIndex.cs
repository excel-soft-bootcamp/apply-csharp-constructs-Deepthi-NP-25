using System;
using System.Collections.Generic;
using System.Text;

namespace Health
{
    class BodyMassIndex
    {
        public int weight, height;
        private int total;

        public int SetHeight
        {
            set
            {
                this.height = value;
            }
        }
        public int SetWeight
        {
            set
            {
                this.weight = value;
            }
        }
        public int Calculator()
        {
             return total = weight / height;
           
        }
       
    }
}

        
    

        









