using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Staff : CollegeMember
    {
       string designation;
        public Staff(string name, string address, string designation) : base(name, address)
        {
            this.designation = designation;
        }
    }
}
 
