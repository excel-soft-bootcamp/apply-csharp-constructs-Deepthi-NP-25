
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Health
{
    class Calculate
    {
        private int height, weight, result;

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

