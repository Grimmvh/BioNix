using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class Contracts
    {
        private string clientID;
        private DateTime DateSigned;
        private string ContractID;
        private string slaID;

        public Contracts() { }
        public Contracts(string clientID, DateTime dateSigned, string contractID, string slaID)
        {
            this.clientID = clientID;
            DateSigned = dateSigned;
            ContractID = contractID;
            this.slaID = slaID;
        }

        public string ClientID { get => clientID; set => clientID = value; }
        public DateTime DateSigned1 { get => DateSigned; set => DateSigned = value; }
        public string ContractID1 { get => ContractID; set => ContractID = value; }
        public string SlaID { get => slaID; set => slaID = value; }

        public override bool Equals(object obj)
        {
            return obj is Contracts contracts &&
                   clientID == contracts.clientID &&
                   DateSigned == contracts.DateSigned &&
                   ContractID == contracts.ContractID &&
                   slaID == contracts.slaID;
        }

        public override int GetHashCode()
        {
            int hashCode = 1767149606;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clientID);
            hashCode = hashCode * -1521134295 + DateSigned.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContractID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(slaID);
            return hashCode;
        }
    }
}
