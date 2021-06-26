using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student : CollegeMember
    {
        private string rollno;
        private int year;
        public Student(string name, string address, string rollno, int year) :
            base(name, address)
        {

            this.rollno = rollno;
            this.year = year;
        }
    }
}
        











