using System;
using System.Collections.Generic;
using Teams_Library;

namespace Students_Library
{
    //rename mode press ctrl + "R" x2 
    //basic information of person placeholder
    public class Students
    {
        public string studentName;
        public Teams team;
       


        //add constructor press alt+enter pick add contructor
        public Students(string name, Teams team)
        {
            this.studentName = name;
            this.team = team;
            
        }
    }
    //add persons to a list function
    public class AddStudent
    {
        public List<Students> studentList;

        public AddStudent()
        {
            studentList = new List<Students>();
        }

        public void AddStudents(Students students)
        {
            studentList.Add(students);
        }
    }
}
