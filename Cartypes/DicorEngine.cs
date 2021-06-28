using System;
using System.Collections.Generic;
using System.Text;

namespace Cartypes
{
    public class DicorEngine : IEngine
    {
        public void start()
        {
            Console.WriteLine("DicorEngine start");
        }
        public void stop()
        {
            Console.WriteLine("DicorEngine stop");
        }
    }
}
