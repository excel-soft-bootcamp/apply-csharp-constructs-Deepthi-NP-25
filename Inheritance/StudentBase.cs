using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class StudentBase : College
    {
        private string studentname;
        public StudentBase(string collegecode, string collegename, string studentname) :
            base(collegecode, collegename)
        {

            this.studentname = studentname;
        }
    }
}
        











