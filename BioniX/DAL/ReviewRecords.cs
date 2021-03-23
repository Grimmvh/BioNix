using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class ReviewRecords
    {
        private string ReviewID;
        private string clientID;
        private DateTime StartTimeStamp;
        private DateTime EndTimeStamp;
        private string staffID;

        public ReviewRecords() { }
        public ReviewRecords(string reviewID, string clientID, DateTime startTimeStamp, DateTime endTimeStamp, string staffID)
        {
            ReviewID = reviewID;
            this.clientID = clientID;
            StartTimeStamp = startTimeStamp;
            EndTimeStamp = endTimeStamp;
            this.staffID = staffID;
        }

        public string ReviewID1 { get => ReviewID2; set => ReviewID2 = value; }
        public string ClientID { get => ClientID1; set => ClientID1 = value; }
        public DateTime StartTimeStamp1 { get => StartTimeStamp2; set => StartTimeStamp2 = value; }
        public DateTime EndTimeStamp1 { get => EndTimeStamp2; set => EndTimeStamp2 = value; }
        public string StaffID { get => StaffID1; set => StaffID1 = value; }
        public string ReviewID2 { get => ReviewID; set => ReviewID = value; }
        public string ClientID1 { get => clientID; set => clientID = value; }
        public DateTime StartTimeStamp2 { get => StartTimeStamp; set => StartTimeStamp = value; }
        public DateTime EndTimeStamp2 { get => EndTimeStamp; set => EndTimeStamp = value; }
        public string StaffID1 { get => staffID; set => staffID = value; }
    }
}
