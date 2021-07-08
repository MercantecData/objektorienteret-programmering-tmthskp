using System;

namespace _1st_Class_Library
{
    class Program_1st_Library
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("Working Dude", 10000);

            //Add Person 1
            Person person1 = new Person("Jhon", 40, job1, job1);
            AddPerson addPerson = new AddPerson();

            Console.WriteLine("Name " + person1.name + "\nAge " + person1.age + "\nJob " + job1.jobName + "\nJobMonthly " + job1.jobMonthly);

            addPerson.AddPersons(person1);


            //Add Person 2
            Person person2 = new Person("Boerge", 50, job1, job1);
            AddPerson addPerson2 = new AddPerson();

            Console.WriteLine("Name " + person2.name + "\nAge " + person2.age + "\nJob " + job1.jobName + "\nJobMonthly " + job1.jobMonthly);

            addPerson.AddPersons(person2);
        }
    }
}
