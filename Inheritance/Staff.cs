using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Staff : College
    {
       string _staffname;
        public Staff(string collegecode, string collegename, string staffname) :
            base(collegecode, collegename)
        {
            this._staffname = staffname;
        }
    }
}
 
