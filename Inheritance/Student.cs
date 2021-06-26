using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student : College
    {
        string _studentname;
        public Student(string collegecode, string collegename, string studentname) :
            base(collegecode, collegename)
        {

            this._studentname = studentname;
        }
    }
}
        











