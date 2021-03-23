using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class Jobs
    {
        private string JobID;
        private DateTime Date;
        private string Services;
        private string Status;
        private string StaffID;

        public Jobs() { }
        public Jobs(string jobID, DateTime date, string services, string status, string staffID)
        {
            JobID = jobID;
            Date = date;
            Services = services;
            Status = status;
            StaffID = staffID;
        }

        public string JobID1 { get => JobID; set => JobID = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public string Services1 { get => Services; set => Services = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string StaffID1 { get => StaffID; set => StaffID = value; }

        public override bool Equals(object obj)
        {
            return obj is Jobs jobs &&
                   JobID == jobs.JobID &&
                   Date == jobs.Date &&
                   Services == jobs.Services &&
                   Status == jobs.Status &&
                   StaffID == jobs.StaffID;
        }

        public override int GetHashCode()
        {
            int hashCode = -2065667758;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JobID);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Services);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StaffID);
            return hashCode;
        }
    }
}
