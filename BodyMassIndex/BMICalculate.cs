
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Health
{
    class BMICalculate
    {
        private int height, weight, result = 0;

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
        public int CalculateResult(int result)
        {
            return result = weight / height;

        }
    }
}

