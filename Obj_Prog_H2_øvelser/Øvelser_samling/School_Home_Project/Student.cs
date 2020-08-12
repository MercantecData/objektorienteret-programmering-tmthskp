using System;
using System.Collections.Generic;
using System.Text;

namespace School_Home_Project
{
    public class Student
    {
        public string Name;
        public Team team;

        //add constructor press alt+enter pick add contructor
        public Student(string name, Team team)
        {
            this.Name = name;
            this.team = team;
        }
    }
}
