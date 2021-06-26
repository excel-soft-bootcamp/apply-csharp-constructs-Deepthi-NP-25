using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Teacher : CollegeMember
    {
        private string dept;
        public Teacher(string name, string address,string dept) : base(name, address)
        { 
            this.dept = dept;
        }
    }
}



