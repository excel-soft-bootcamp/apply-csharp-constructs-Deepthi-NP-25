using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class GuestBase : College
    {
        private string guestname;
        public GuestBase(string collegecode, string collegename, string guestname) :
            base(collegecode, collegename)
        {
            this.guestname = guestname;
        }
    }
}
 





