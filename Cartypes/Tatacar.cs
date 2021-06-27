using System;
using System.Collections.Generic;
using System.Text;

namespace Cartypes
{
    public class Tatacar
    {
        Enginetype enginetype;
        public Tatacar(Enginetype enginetype)
        {
            this.enginetype = enginetype;
        }
        public void drive()
        {
            enginetype.start();
        }
        public void halt()
        {
            enginetype.stop();
        }
    }
}
