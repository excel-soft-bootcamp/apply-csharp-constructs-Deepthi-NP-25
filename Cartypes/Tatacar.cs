using System;
using System.Collections.Generic;
using System.Text;

namespace Cartypes
{
    public class Tatacar
    {
        IEngine iengine;
        public Tatacar(IEngine iengine)
        {
            this.iengine = iengine;
        }
        public void drive()
        {
            iengine.start();
        }
        public void halt()
        {
            iengine.stop();
        }
    }
}
