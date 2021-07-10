using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSecuritySolution
{
    public class SecuritySystem
    {
        public void Notify(string position)
        {
            Console.WriteLine("Door is" + position + "at" + DateTime.Now.ToString());
        }
    }
}