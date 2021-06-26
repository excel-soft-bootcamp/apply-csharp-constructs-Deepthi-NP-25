using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        public static void Main(String [] args)
        {
            Student student = new Student("Tom", "Mysore", "A01", 1);
            Teacher teacher = new Teacher("Jerry", "Bangalore", "ComputerScience");
            Staff staff = new Staff("Oswald", "Mandya", "Librarian");
            Guest guestbase = new Guest("Henry", "Chikmagalur", "Staffmember");

            
        }
    }
}
