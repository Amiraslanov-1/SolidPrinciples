using System;
using System.Collections.Generic;
namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            bool ischek = true;
            do
            {


                Console.WriteLine("1.Add a student");
                Console.WriteLine("2.Add an exam to the student");
                Console.WriteLine("3.Look at a student's exam score");
                Console.WriteLine("4.Show all student exams");
                Console.WriteLine("5.Show the student's exam average");
                Console.WriteLine("6.Remove the exam for the student");
                Console.WriteLine("0.The program ends\n");

                Console.WriteLine("Make Your Choice : ");
                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":

                        Console.WriteLine("Enter the Fullname of Student :");
                        string fullname = Console.ReadLine();
                        while (!ValidationMethods.CheckFullName(fullname))
                        {

                            Console.WriteLine("Enter Correctly :");
                            fullname = Console.ReadLine();

                        }
                        Student student = new Student(fullname);
                        students.Add(student);


                        break;
                    case "2":
                        Console.WriteLine("Enter Exam Name :");
                        string examName = Console.ReadLine();

                        while (!ValidationMethods.Exam(examName))
                        {
                            Console.WriteLine("There is an exam under this name:");
                            examName = Console.ReadLine();

                        }
                        Console.WriteLine("Enter Student Point :");
                        double examPoint;
                        string examStr = Console.ReadLine();
                        bool check = double.TryParse(examStr, out examPoint);
                        while (!check)
                        {
                            Console.WriteLine("Enter Correctly :");
                            examStr = Console.ReadLine();
                            check = double.TryParse(examStr, out examPoint);
                        }

                        MethodsForExam.AddExam(examName, examPoint);



                        break;
                    case "3":
                        Console.WriteLine("Enter The Name Of The Exam:");
                        string search = Console.ReadLine();
                        Console.WriteLine("Enter No : ");
                        int no;
                        string noStr = Console.ReadLine();
                        bool chekStr = int.TryParse(noStr, out no);

                        while (!chekStr)
                        {
                            Console.WriteLine("Enter Correctly : ");
                            noStr = Console.ReadLine();
                            chekStr = int.TryParse(noStr, out no);

                        }

                        foreach (Student student1 in students)
                        {
                            if (student1.No == no)
                            {
                                try
                                {
                                    Console.WriteLine($"Exam Point : {MethodsForExam.GetExamResult(search)}");

                                }
                                catch (StudentNotFound EX)
                                {

                                    Console.WriteLine(EX.Message);
                                }
                            }

                        }
                        break;

                    case "4":

                        Console.WriteLine("Enter No : ");
                        int firstNo;
                        string firstStr = Console.ReadLine();
                        bool firstCheck = int.TryParse(firstStr, out firstNo);

                        while (!firstCheck)
                        {
                            Console.WriteLine("Enter Correctly :");
                            firstStr = Console.ReadLine();
                            firstCheck = int.TryParse(firstStr, out firstNo);
                        }

                        foreach (Student st in students)
                        {
                            if (st.No == firstNo)
                            {
                                st.ShowInfo();
                            }
                            Console.WriteLine("Student is Not Found !");

                        }

                        break;
                    case "5":

                        Console.WriteLine("Enter No : ");
                        int avgNo;
                        string avgStr = Console.ReadLine();
                        bool avgCheck = int.TryParse(avgStr, out avgNo);

                        while (!avgCheck)
                        {
                            Console.WriteLine("Enter Correctly :");
                            avgStr = Console.ReadLine();
                            avgCheck = int.TryParse(avgStr, out avgNo);
                        }

                        foreach (Student st in students)
                        {
                            if (st.No == avgNo)
                            {

                                Console.WriteLine($"AVG Point : {MethodsForExam.GetExamAvg()}");
                            }
                            else
                            {
                                Console.WriteLine("Exam Not Found!");
                            }

                        }

                        break;
                    case "6":
                        Console.WriteLine("Enter The Name Of The Exam You Want To Delete :");
                        string searchExam = Console.ReadLine();
                        Console.WriteLine("Enter No : ");
                        int removeNo;
                        string removeStr = Console.ReadLine();
                        bool chekremoveStr = int.TryParse(removeStr, out removeNo);

                        while (!chekremoveStr)
                        {
                            Console.WriteLine("Enter Correctly : ");
                            removeStr = Console.ReadLine();
                            chekremoveStr = int.TryParse(removeStr, out removeNo);

                        }

                        foreach (Student student1 in students)
                        {
                            if (student1.No == removeNo)
                            {

                                MethodsForExam.RemoveExam(searchExam);

                            }
                            else
                            {
                                Console.WriteLine("Exam Not Found !");
                            }

                        }
                        break;
                    case "0":
                        ischek = false;
                        break;

                    default:
                        break;
                }






            } while (ischek);
        }
    }
}
