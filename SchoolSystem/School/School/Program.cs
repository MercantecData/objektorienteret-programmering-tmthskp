using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();

            void Start()
            {
                Console.WriteLine("\nChoose what you want to do");
                Console.WriteLine("1 = Students overview.  2 = Employees overview.");
                string userResponse = Console.ReadLine();
                switch (userResponse.ToLower())
                {
                    case "1":
                        StudentOverview();
                        break;

                    case "2":
                        TeacherOverview();
                        break;

                    default:
                        Console.WriteLine("didn't understand that. You must write what you wanna do");
                        Start();
                        break;                      
                }
            }

            void StudentOverview()
            {
                Console.WriteLine("Hello This is the school students overview");

                List<Student> StudentList = new List<Student>();
                StudentList.Add(new Student("Jhon", new Team("hold 1")));
                StudentList.Add(new Student("Don", new Team("hold 1")));
                StudentList.Add(new Student("Bonn", new Team("hold 1")));
                StudentList.Add(new Student("Sam", new Team("hold 2")));
                StudentList.Add(new Student("Lilly", new Team("hold 2")));

                for (int i = 0; i < StudentList.Count; i++)
                {
                    Console.WriteLine(StudentList[i].Name + ", " + StudentList[i].team.teamName);
                }
                Start();
            }

            void TeacherOverview()
            {
                Console.WriteLine("\nOverview of the employes. Who got paid and teams they attend ");

                List<Teacher> TeacherList = new List<Teacher>();
                TeacherList.Add(new Teacher("Davidson", new Team("hold 1"), new Sallary("Yes")));
                TeacherList.Add(new Teacher("Jhonson", new Team("hold 1"), new Sallary("Yes")));
                TeacherList.Add(new Teacher("Henricson", new Team("hold 2"), new Sallary("No")));

                for (int i = 0; i < TeacherList.Count; i++)
                {
                    Console.WriteLine(TeacherList[i].teacherName + ", " + TeacherList[i].team.teamName);
                }
                Start();
            }

        }
    }
}
