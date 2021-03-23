using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class Issues
    {
        private string clientID;
        private string IssueID;
        private DateTime ReportDate;
        private string Status;
        private string StaffID;
        private string Description;

        public Issues() { }
        public Issues(string clientID, string issueID, DateTime reportDate, string status, string staffID, string description)
        {
            this.clientID = clientID;
            IssueID = issueID;
            ReportDate = reportDate;
            Status = status;
            StaffID = staffID;
            Description = description;
        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string IssueID1 { get => IssueID; set => IssueID = value; }
        public DateTime ReportDate1 { get => ReportDate; set => ReportDate = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string StaffID1 { get => StaffID; set => StaffID = value; }
        public string Description1 { get => Description; set => Description = value; }

        public override bool Equals(object obj)
        {
            return obj is Issues issues &&
                   clientID == issues.clientID &&
                   IssueID == issues.IssueID &&
                   ReportDate == issues.ReportDate &&
                   Status == issues.Status &&
                   StaffID == issues.StaffID &&
                   Description == issues.Description;
        }

        public override int GetHashCode()
        {
            int hashCode = 329266283;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IssueID);
            hashCode = hashCode * -1521134295 + ReportDate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StaffID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }
    }
}
