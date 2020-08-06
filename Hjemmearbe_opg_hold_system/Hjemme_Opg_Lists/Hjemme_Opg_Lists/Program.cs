using System;
using System.Collections.Generic;
using Students_Library;
using Teams_Library;
using Employee_Library;
using Sallary_Paid;


namespace Hjemme_Opg_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            Teams team1 = new Teams("Know they self team. ");
            Teams team2 = new Teams("Know the others team. ");
            SallaryPaid paid1 = new SallaryPaid("Yes! ");
            SallaryPaid paid2 = new SallaryPaid("NO!!! ");

            //--- Adding students
            //Add student 1
            Students student1 = new Students("Jhon. ", team1);
            AddStudent addStudent = new AddStudent();
            addStudent.AddStudents(student1);

            //Add student 2
            Students student2 = new Students("Bob. ", team1);
            AddStudent addStudent2 = new AddStudent();
            addStudent2.AddStudents(student2);

            //Add student 3
            Students student3 = new Students("Steff. ", team1);
            AddStudent addStudent3 = new AddStudent();
            addStudent3.AddStudents(student3);

            //Add student 4
            Students student4 = new Students("Jasper. ", team2);
            AddStudent addStudent4 = new AddStudent();
            addStudent4.AddStudents(student4);

            //Add student 5
            Students student5 = new Students("Anni. ", team2);
            AddStudent addStudent5 = new AddStudent();
            addStudent5.AddStudents(student5);

           
            //--- Adding Employees
            //Add Employee 1
            Employees employee1 = new Employees("Jameson. ", paid1, team1);
            AddEmployee addEmployee1 = new AddEmployee();
            addEmployee1.AddEmployees(employee1);
            
            //Add Employee 2
            Employees employee2 = new Employees("Davidson. ", paid2, team1);
            AddEmployee addEmployee2 = new AddEmployee();
            addEmployee2.AddEmployees(employee2);

            //Add Employee 3
            Employees employee3 = new Employees("Staffano. ", paid1, team2);
            AddEmployee addEmployee3 = new AddEmployee();
            addEmployee3.AddEmployees(employee3);
           
            Console.WriteLine("Hello This is the school students and employees overview");
            start();
            
           void start()
                {
                    Console.WriteLine("\nChoose what you want to do");
                    Console.WriteLine("1 = Students overview.  2 = Employees overview.  3 = (Lokal liste elever test)");
                    string userResponse = Console.ReadLine();
                    switch (userResponse.ToLower())
                    {
                        case "1":
                            StudentOverview();
                            break;
                        case "2":
                            EmployeeOverview();
                            break;

                        case "3":
                            elever();
                             break;
                        default:
                            Console.WriteLine("didn't understand that. You must write what you wanna do");
                            break;

                    }
            }

            void StudentOverview()
            {
                Console.WriteLine("Hello This is the school students overview");
                Console.WriteLine("Student name: " + student1.studentName + "Team name: " + team1.teamName);
                Console.WriteLine("Student name: " + student2.studentName + "Team name: " + team1.teamName);
                Console.WriteLine("Student name: " + student3.studentName + "Team name: " + team1.teamName);
                Console.WriteLine("Student name: " + student4.studentName + "Team name: " + team2.teamName);
                Console.WriteLine("Student name: " + student5.studentName + "Team name: " + team2.teamName);
                start();
            }

            void EmployeeOverview() 
            {
                Console.WriteLine("\nOverview of the employes. Who got paid and teams they attend ");
                Console.WriteLine("Employee name: " + employee1.employeeName + "Team name: " + team1.teamName + "Sallary paid: " + paid1.sallaryPaid);
                Console.WriteLine("Employee name: " + employee2.employeeName + "Team name: " + team1.teamName + "Sallary paid: " + paid2.sallaryPaid);
                Console.WriteLine("Employee name: " + employee3.employeeName + "Team name: " + team2.teamName + "Sallary paid: " + paid1.sallaryPaid);
                start();
            }

            // Dete er en test method lavet for at forsøge mig frem med list funktionen
            void elever()
            {
                List<string> elever = new List<string>();
                elever.Add("Anders Team 1 "); // Add string 1
                elever.Add("Børge Team2 "); // 2
                elever.Add("Massha "); // 3
                elever.Add("Simon " + team1); // 4
                elever.Add("Brian "); // 5
               // elever.Add("Peter ", team1); // 6

                string elevliste = string.Join(", ", elever.ToArray());
                Console.WriteLine(elevliste);
                start();
            }
        }

    }
}
