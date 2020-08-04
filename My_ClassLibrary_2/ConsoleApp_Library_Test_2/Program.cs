using System;
using System.Collections.Generic;
using My_ClassLibrary_2;
using Job_Library;


namespace ConsoleApp_Library_Test_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Job job1 = new Job("Working Dude", 10000);          
            
            //Add Person 1
            Persons person1 = new Persons("Jhon", 40, job1, job1);
            AddPerson addPerson = new AddPerson();

            Console.WriteLine("Name " + person1.name + "\nAge " + person1.age + "\nJob " + job1.jobName + "\nJobMonthly " + job1.jobMonthly);

            addPerson.AddPersons(person1);


            //Add Person 2
            Persons person2 = new Persons("Boerge", 50, job1,job1);
            AddPerson addPerson2 = new AddPerson();

            Console.WriteLine("Name " + person2.name + "\nAge " + person2.age + "\nJob " + job1.jobName + "\nJobMonthly " + job1.jobMonthly);

            addPerson.AddPersons(person2);

        }
    }
}
