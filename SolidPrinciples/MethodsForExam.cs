using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    public class MethodsForExam
    {


        public static void AddExam(string examName ,double point)
        {
            Student.Students.Add(examName, point);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Exam Added Date: {dateTime}\n");
        }
        public static double GetExamResult(string examName)
        {
            var result= Student.Students.GetValueOrDefault(examName);
            if (result==0)
            {
                throw new StudentNotFound("Student Not Found!");
            }
            return result;
        }
        public static double GetExamAvg()
        {
            double sum = 0;
            foreach (var student in Student.Students)
            {
                sum += student.Value;

            }
            sum /= Student.Students.Count;

            return sum;
        }
        public static void RemoveExam(string exam)
        {
            Student.Students.Remove(exam);
        }

    }
}
