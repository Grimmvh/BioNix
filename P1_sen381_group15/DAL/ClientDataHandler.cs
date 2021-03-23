using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class ClientDataHandler
    {
        string connection = "";
        public List<Clients> GetClients() 
        {
            return null;
        }
        public string GetClientAdress(string Clients)
        {
            return null;
        }
        public Tuple<string,string> GetClientContract(string Clients)
        {
            return null;
        }
        public List<CallRecords> GetClientRecords(string Clients)
        {
            return null;
        }
        public bool SetClientRecords(string Clients, DateTime StartTimeStamp, DateTime EndTimeStamp, string staffID)
        {
            return true;
        }
        public List<JobRecords> GetClientJobRecords(string Clients)
        {
            return null;
        }
        public List<ReviewRecords> GetReviews(string Clients)
        {
            return null;
        }
        public bool SetReview(string Rating, string status, DateTime timeStamp)
        {
            return true;
        }
    }
}
