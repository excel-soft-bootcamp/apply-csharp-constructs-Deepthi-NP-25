﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class PatientBMIResult
    {
        public string Name { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public double BMIValue { get; set; }

        public string Result { get; set; }
    }
}
