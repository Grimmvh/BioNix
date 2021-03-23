using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class IssueCentre
    {
        private string staffID;
        private List<Issues> issues;
        private Issues issue;

        public IssueCentre(string staffID, List<Issues> issues, Issues issue)
        {
            this.staffID = staffID;
            this.issues = issues;
            this.issue = issue;
        }
        public IssueCentre(){ }
        public override bool Equals(object obj)
        {
            return obj is IssueCentre centre &&
                   staffID == centre.staffID &&
                   EqualityComparer<List<Issues>>.Default.Equals(issues, centre.issues) &&
                   EqualityComparer<Issues>.Default.Equals(issue, centre.issue);
        }

        public override int GetHashCode()
        {
            int hashCode = -233730795;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(staffID);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Issues>>.Default.GetHashCode(issues);
            hashCode = hashCode * -1521134295 + EqualityComparer<Issues>.Default.GetHashCode(issue);
            return hashCode;
        }
        public List<Issues> GetIssues(string clientID)
        {
            return null;
        }
        public bool CreateIssue()
        {
            return false;
        }
    }
}
