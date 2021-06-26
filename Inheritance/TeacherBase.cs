using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class TeacherBase : College
    {
        private string teachername;
        public TeacherBase(string collegecode, string collegename, string teachername) :
            base(collegecode, collegename)
        { 
            this.teachername = teachername;
        }
    }
}



