using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class Request
    {
        private Clients client;
        private DateTime PlannedDate;
        private DateTime DeadlineDate;

        public Request(Clients client, DateTime plannedDate, DateTime deadlineDate)
        {
            this.client = client;
            PlannedDate = plannedDate;
            DeadlineDate = deadlineDate;
        }
        public Request(){ }

        public override bool Equals(object obj)
        {
            return obj is Request request &&
                   EqualityComparer<Clients>.Default.Equals(client, request.client) &&
                   PlannedDate == request.PlannedDate &&
                   DeadlineDate == request.DeadlineDate;
        }

        public override int GetHashCode()
        {
            int hashCode = 181794376;
            hashCode = hashCode * -1521134295 + EqualityComparer<Clients>.Default.GetHashCode(client);
            hashCode = hashCode * -1521134295 + PlannedDate.GetHashCode();
            hashCode = hashCode * -1521134295 + DeadlineDate.GetHashCode();
            return hashCode;
        }
        public bool CreateRequest(string client, DateTime PlannedDate, DateTime Deadline)
        {
            return false;
        }
    }
}
