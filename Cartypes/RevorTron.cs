using System;
using System.Collections.Generic;
using System.Text;

namespace Cartypes
{
    public class RevorTron : IEngine
    {
        public void start()
        {
            Console.WriteLine("RevorTron start");
        }
        public void stop()
        {
            Console.WriteLine("RevorTron stop");
        }
    }
}
