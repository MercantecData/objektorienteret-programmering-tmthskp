using System;
using System.Collections.Generic;
using System.Text;

namespace _1st_Class_Library
{
    public class Job
    {
        public string jobName;
        public double jobMonthly;

        public Job(string jobName, double jobMonthly)
        {
            this.jobName = jobName;
            this.jobMonthly = jobMonthly;
        }
    }
}
