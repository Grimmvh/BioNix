using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class ContractManagement
    {
        private string contractID;
        private Contracts contract;
        private List<Contracts> contracts;

        public ContractManagement(string contractID, Contracts contract, List<Contracts> contracts)
        {
            this.contractID = contractID;
            this.contract = contract;
            this.contracts = contracts;
        }

        public ContractManagement(){}
        public override bool Equals(object obj)
        {
            return obj is ContractManagement management &&
                   contractID == management.contractID &&
                   EqualityComparer<Contracts>.Default.Equals(contract, management.contract) &&
                   EqualityComparer<List<Contracts>>.Default.Equals(contracts, management.contracts);
        }

        public override int GetHashCode()
        {
            int hashCode = -170312455;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contractID);
            hashCode = hashCode * -1521134295 + EqualityComparer<Contracts>.Default.GetHashCode(contract);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Contracts>>.Default.GetHashCode(contracts);
            return hashCode;
        }
        public Contracts GetContracts(string contractID)
        {
            return null;
        }
        public List<Contracts> GetContracts()
        {
            return null;
        }
        public bool CreateContract()
        {
            return false;
        }
        public bool DeleteContract(string ContractID)
        {
            return false;
        }
        public bool EditContract(string ContractID)
        {
            return false;
        }
    }
}

