using System;
using System.Collections.Generic;
using Job_Library;

namespace My_ClassLibrary_2
{
    //rename mode press ctrl + "R" x2 
    //basic information of person placeholder
    public class Persons
    {
        public string name;
        public int age;
        public Job job;
        public Job jobPay;
        
        
        //add constructor press alt+enter pick add contructor
        public Persons(string name, int age, Job job, Job jobPay)
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
        public List<Persons> personList;

        public AddPerson()
        {
            personList = new List<Persons>();
        }

        public void AddPersons(Persons persons) 
        {
            personList.Add(persons);
        }
    }
}
