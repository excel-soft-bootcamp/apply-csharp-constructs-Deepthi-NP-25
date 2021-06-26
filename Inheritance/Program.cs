using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        public static void main(String [] args)
        {
            StudentBase studentbase = new StudentBase("A01", "VTU", "Tom");
            TeacherBase teacherbase = new TeacherBase("A01", "VTU", "Jerry");
            StaffBase staffbase = new StaffBase("A01", "VTU", "Oswald");
            GuestBase guestbase = new GuestBase("A01", "VTU", "Henry");

            
        }
    }
}
