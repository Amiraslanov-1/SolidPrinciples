using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class StudentNotFound:Exception
    {
        public StudentNotFound(string msg):base(msg)
        {

        }
    }
}
