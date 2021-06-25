using System;
using System.Collections.Generic;
using System.Text;

namespace Health
{
    class BodyMassIndex
    {
        public int weight, height;
      

        public int GetWeight()
        {
            return weight;
        }
        public int GetHeight()
        {
            return height;
        }
        public BodyMassIndex(int BodyMassIndex)
        {
            BodyMassIndex = weight / height;
            
        }

        public BodyMassIndex()
        {
        BodyMassIndex bmi = new BodyMassIndex();
        }
    }
    }

        









