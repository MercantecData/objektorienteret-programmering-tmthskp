using System;
using System.Collections.Generic;
using System.Text;

namespace _1st_Class_Library
{
   
        //rename mode press ctrl + "R" x2 
        //basic information of person placeholder
        public class Person
        {
            public string name;
            public int age;
            public Job job;
            public Job jobPay;


            //add constructor press alt+enter pick add contructor
            public Person(string name, int age, Job job, Job jobPay)
            {
                this.name = name;
                this.age = age;
                this.job = job;
                this.jobPay = jobPay;
            }
        }

        //add persons to list function
        public class AddPerson
        {
            public List<Person> personList;

            public AddPerson()
            {
                personList = new List<Person>();
            }

            public void AddPersons(Person person)
            {
                personList.Add(person);
            }
        }
    
}
