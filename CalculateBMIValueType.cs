﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculateBMIValueLib
{
    public class CalculateBMIValueType
    {
        public double BmiCalculation(double height, double weight)
        {
            double bmivalue = weight / height;
            return bmivalue;

        }
    }
}
