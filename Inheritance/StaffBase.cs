using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class StaffBase : College
    {
        private string staffname;
        public StaffBase(string collegecode, string collegename, string staffname) :
            base(collegecode, collegename)
        {
            this.staffname = staffname;
        }
    }
}
 
