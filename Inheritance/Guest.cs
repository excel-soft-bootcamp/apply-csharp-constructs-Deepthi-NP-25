using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Guest : CollegeMember
    {
        private string persontovisit;
        public Guest(string name, string address, string persontovisit) : base(name, address)
        {
            this.persontovisit = persontovisit;
        }
    }
}
 





