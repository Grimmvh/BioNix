using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class RequestData
    {
        //private string Clients;    weet nie???

        private string RequestID;
        private DateTime PlannedDate;
        private DateTime DeadLine;

        public RequestData() { }
        public RequestData(string requestID, DateTime plannedDate, DateTime deadLine)
        {
            RequestID = requestID;
            PlannedDate = plannedDate;
            DeadLine = deadLine;
        }

        public string RequestID1 { get => RequestID; set => RequestID = value; }
        public DateTime PlannedDate1 { get => PlannedDate; set => PlannedDate = value; }
        public DateTime DeadLine1 { get => DeadLine; set => DeadLine = value; }

        public override bool Equals(object obj)
        {
            return obj is RequestData data &&
                   RequestID == data.RequestID &&
                   PlannedDate == data.PlannedDate &&
                   DeadLine == data.DeadLine;
        }

        public override int GetHashCode()
        {
            int hashCode = 798486629;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RequestID);
            hashCode = hashCode * -1521134295 + PlannedDate.GetHashCode();
            hashCode = hashCode * -1521134295 + DeadLine.GetHashCode();
            return hashCode;
        }
    }
}
