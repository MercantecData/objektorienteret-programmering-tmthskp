using System;
using System.Collections.Generic;
using Teams_Library;
using Sallary_Paid;

namespace Employee_Library
{
    public class Employees
    {
        public string employeeName;
        public SallaryPaid sallaryPaid;
        public Teams team;



        //add constructor press alt+enter pick add contructor
        public Employees(string name, SallaryPaid sallaryPaid, Teams team)
        {
            this.employeeName = name;
            this.sallaryPaid = sallaryPaid;
            this.team = team;
        }

    }

    //add persons to a list function
    public class AddEmployee
    {
        public List<Employees> employeeList;

        public AddEmployee()
        {
            employeeList = new List<Employees>();
        }

        public void AddEmployees(Employees employees)
        {
            employeeList.Add(employees);
        }
    }
}
