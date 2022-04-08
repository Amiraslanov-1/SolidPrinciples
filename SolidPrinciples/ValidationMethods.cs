using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class ValidationMethods
    {

        public static bool CheckFullName(string fullname)
        {
            if (!string.IsNullOrWhiteSpace(fullname) && fullname.Length > 8 && fullname.Length < 30)
            {

                for (int i = 0; i < fullname.Length; i++)
                {
                    if (!char.IsLetter(fullname[i]))

                        return false;

                }
                return true;

            }
            return false;
        }


        public static bool Exam(string examName)
        {
            if (Student.Students.ContainsKey(examName))
            {
                return false;
            }
            return true;
        }
    }
}
