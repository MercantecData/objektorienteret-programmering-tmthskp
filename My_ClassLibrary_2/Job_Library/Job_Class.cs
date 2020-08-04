using System;
using System.Collections.Generic;

namespace Job_Library
{
    //Job desription placeholder
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
