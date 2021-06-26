using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class CollegeMember
    {
        private string name, address;
        /*public CollegeMember(string collegecode) 
        {
            this.collegecode = collegecode;
        }

        public CollegeMember(string collegecode, string collegename) : this(collegecode)
        {

            this.collegename = collegename;

        }*/
        public CollegeMember(string name) 
        {
            this.name = name;
        }
        public CollegeMember(string name, string address)
            : this(name)
        {
            this.address = address;
        }
    }
}

