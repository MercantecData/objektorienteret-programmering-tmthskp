using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Teacher
    {

        public string teacherName;
        public Sallary sallary;
        public Team team;

        public Teacher(string teacherName, Team team, Sallary sallary)
        {
            this.teacherName = teacherName;
            this.team = team;
            this.sallary = sallary;
            
        }
    }

}
