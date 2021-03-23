using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class CallRecords
    {
        private string callRecordID;
        private string clientID;
        private DateTime StartTimeStamp;
        private DateTime EndTimeStamp;
        private string staffID;

        public CallRecords() { }
        public CallRecords(string callRecordID, string clientID, DateTime startTimeStamp, DateTime endTimeStamp, string staffID)
        {
            this.callRecordID = callRecordID;
            this.clientID = clientID;
            StartTimeStamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            this.staffID = staffID;
        }

        public string CallRecordID { get => callRecordID; set => callRecordID = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public DateTime StartTimeStamp1 { get => StartTimeStamp; set => StartTimeStamp = value; }
        public DateTime EndTimeStamp1 { get => EndTimeStamp; set => EndTimeStamp = value; }
        public string StaffID { get => staffID; set => staffID = value; }

        public override bool Equals(object obj)
        {
            return obj is CallRecords records &&
                   callRecordID == records.callRecordID &&
                   clientID == records.clientID &&
                   StartTimeStamp == records.StartTimeStamp &&
                   EndTimeStamp == records.EndTimeStamp &&
                   staffID == records.staffID;
        }

        public override int GetHashCode()
        {
            int hashCode = -87439133;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(callRecordID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + StartTimeStamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EndTimeStamp.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(staffID);
            return hashCode;
        }
    }
}
