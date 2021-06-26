using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Teacher : College
    {
        string _teachername;
        public Teacher(string collegecode, string collegename, string teachername) :
            base(collegecode, collegename)
        { 
            this._teachername = teachername;
        }
    }
}



