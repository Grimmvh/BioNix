using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class JobRecords
    {
        private string JobRecordID;
        private string clientID;
        private string CallRecordId;
        private string Description;
        private string Status;

        public JobRecords() { }
        public JobRecords(string jobRecordID, string clientID, string callRecordId, string description, string status)
        {
            JobRecordID = jobRecordID;
            this.clientID = clientID;
            CallRecordId = callRecordId;
            Description = description;
            Status = status;
        }

        public string JobRecordID1 { get => JobRecordID; set => JobRecordID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string CallRecordId1 { get => CallRecordId; set => CallRecordId = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Status1 { get => Status; set => Status = value; }

        public override bool Equals(object obj)
        {
            return obj is JobRecords records &&
                   JobRecordID == records.JobRecordID &&
                   clientID == records.clientID &&
                   CallRecordId == records.CallRecordId &&
                   Description == records.Description &&
                   Status == records.Status;
        }

        public override int GetHashCode()
        {
            int hashCode = -1977545316;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JobRecordID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CallRecordId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            return hashCode;
        }
    }
}
