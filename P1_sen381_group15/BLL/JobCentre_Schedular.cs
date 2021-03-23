using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class JobCentre_Schedular
    {
        private string staffID;
        private List<Jobs> jobs;

        public JobCentre_Schedular(string staffID, List<Jobs> jobs)
        {
            this.staffID = staffID;
            this.jobs = jobs;
        }
        public JobCentre_Schedular(){ }
        public override bool Equals(object obj)
        {
            return obj is JobCentre_Schedular schedular &&
                   staffID == schedular.staffID &&
                   EqualityComparer<List<Jobs>>.Default.Equals(jobs, schedular.jobs);
        }

        public override int GetHashCode()
        {
            int hashCode = 1885631489;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(staffID);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Jobs>>.Default.GetHashCode(jobs);
            return hashCode;
        }
        public List<Jobs> GetJobs()
        {
            return null;
        }
        public bool CreateJobs(List<Jobs> jobs)
        {
            return false;
        }
        public bool FindOpenSchedule(DateTime Date)
        {
            return false;
        }
    }
}
