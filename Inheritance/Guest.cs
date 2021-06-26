using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Guest : College
    {
        string _guestname;
        public Guest(string collegecode, string collegename, string guestname) :
            base(collegecode, collegename)
        {
            this._guestname = guestname;
        }
    }
}
 





