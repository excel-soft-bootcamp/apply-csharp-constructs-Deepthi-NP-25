using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class College
    {
        private string _collegecode, _collegename;
        public College(string collegecode) 
        {
            this._collegcode = collegecode;
        }

        public College(string collegecode, string collegename) : this(collegecode)
        {

            this._collegename = collegename;

        }
    }
}

