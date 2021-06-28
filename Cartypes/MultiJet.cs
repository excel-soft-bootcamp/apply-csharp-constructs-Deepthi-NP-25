using System;
using System.Collections.Generic;
using System.Text;

namespace Cartypes
{
    public class MultiJet : IEngine
    {
        public void start()
        {
            Console.WriteLine("MultiJet start");
        }
        public void stop()
        {
            Console.WriteLine("MultiJet stop");
        }
    }
}
