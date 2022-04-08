using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class Student
    {
        static int _no;
        public int No { get; }
        public string FullName { get; set; }
        public Student(string fullname)
        {
            _no++;
            No = _no;
            FullName = fullname; 
        }



        static Dictionary<string, double> _students = new Dictionary<string, double>();
        public static Dictionary<string, double> Students { get => _students; }

        public void ShowInfo()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"Exam Name : {item.Key} Point : {item.Value}\n");

            }
        }
        

    }
}
