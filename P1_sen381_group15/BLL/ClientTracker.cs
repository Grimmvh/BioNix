using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class ClientTracker
    {
        private string nationalID;
        private Clients client;
        private string staffID;

        public ClientTracker(string nationalID, Clients client, string staffID)
        {
            this.nationalID = nationalID;
            this.client = client;
            this.staffID = staffID;
        }
        public ClientTracker() { }
        public override bool Equals(object obj)
        {
            return obj is ClientTracker tracker &&
                   nationalID == tracker.nationalID &&
                   EqualityComparer<Clients>.Default.Equals(client, tracker.client) &&
                   staffID == tracker.staffID;
        }

        public override int GetHashCode()
        {
            int hashCode = 507057452;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nationalID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Clients>.Default.GetHashCode(client);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(staffID);
            return hashCode;
        }
        public Clients GetClient(string nationalID)
        {
            return null;
        }
        public List<CallRecords> GetCallRecords(string client)
        {
            return null;
        }
        public bool SetCallRecords(string client, DateTime StartTimeStamp, DateTime EndTimeStamp, string staffID)
        {
            return false;
        }
        public List<JobRecords> GetJobRecords(string client)
        {
            return null;
        }
    }
}
