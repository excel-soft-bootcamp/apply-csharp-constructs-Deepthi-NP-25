using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        public static void main(String [] args)
        {
            Student studentbase = new Student("A01", "VTU", "Tom");
            Teacher teacherbase = new Teacher("A01", "VTU", "Jerry");
            Staff staffbase = new Staff("A01", "VTU", "Oswald");
            Guest guestbase = new Guest("A01", "VTU", "Henry");

            
        }
    }
}
