using System;
using System.Collections.Generic;

namespace My_ClassLibrary_2
{
    //rename mode press ctrl + "R" x2 
    //basic information of person placeholder
    public class Persons
    {
        public string name;
        public int age;
        public Job job;
        
        
        //add constructor press alt+enter pick add contructor
        public Persons(string name, int age, Job job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
    }

    //Job desription placeholder
    public class Job 
    {
        public string jobName;

        public Job(string jobName)
        {
            this.jobName = jobName;
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
