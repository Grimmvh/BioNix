using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class ClientSatisfaction
    {
        private string nationalID;
        private Clients client;
        private int rating;
        private DateTime timestamp;

        public ClientSatisfaction(string nationalID, Clients client, int rating, DateTime timestamp)
        {
            this.nationalID = nationalID;
            this.client = client;
            this.rating = rating;
            this.timestamp = timestamp;
        }
        public ClientSatisfaction(){ }

        public override bool Equals(object obj)
        {
            return obj is ClientSatisfaction satisfaction &&
                   nationalID == satisfaction.nationalID &&
                   EqualityComparer<Clients>.Default.Equals(client, satisfaction.client) &&
                   rating == satisfaction.rating &&
                   timestamp == satisfaction.timestamp;
        }

        public override int GetHashCode()
        {
            int hashCode = -1445159301;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nationalID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Clients>.Default.GetHashCode(client);
            hashCode = hashCode * -1521134295 + rating.GetHashCode();
            hashCode = hashCode * -1521134295 + timestamp.GetHashCode();
            return hashCode;
        }
        public Clients GetClient(string nationalID)
        {
            return null;
        }
        public List<JobRecords> GetJobRecords(string Clients)
        {
            return null;
        }
        public List<ReviewRecords> GetReview(string client)
        {
            return null;
        }
        public bool SetReview(int rating, string status, DateTime timestamp)
        {
            return false;
        }
        public bool SetCallRecords(string client, DateTime StartTimeStamp, DateTime EndTimeStamp, string staffID)
        {
            return false;
        }
    }
}
