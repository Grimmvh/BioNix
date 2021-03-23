using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class RequestTracker
    {
        private string StaffID;

        public RequestTracker(string staffID)
        {
            StaffID = staffID;
        }
        public RequestTracker(){ }
        public override bool Equals(object obj)
        {
            return obj is RequestTracker tracker &&
                   StaffID == tracker.StaffID;
        }

        public override int GetHashCode()
        {
            return 1337741220 + EqualityComparer<string>.Default.GetHashCode(StaffID);
        }
        public List<RequestData> GetRequests()
        {
            return null;
        }
        public List<RequestData> GetRequests(string ClientID)
        {
            return null;
        }
    }
}
