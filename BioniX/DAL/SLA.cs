using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class SLA
    {
        private string slaID;
        private string name;
        private string Description;
        private double tarif;

        public SLA() { }
        public SLA(string slaID, string name, string description, double tarif)
        {
            this.slaID = slaID;
            this.name = name;
            Description = description;
            this.tarif = tarif;
        }

        public string SlaID { get => slaID; set => slaID = value; }
        public string Name { get => name; set => name = value; }
        public string Description1 { get => Description; set => Description = value; }
        public double Tarif { get => tarif; set => tarif = value; }

        public override bool Equals(object obj)
        {
            return obj is SLA sLA &&
                   slaID == sLA.slaID &&
                   name == sLA.name &&
                   Description == sLA.Description &&
                   tarif == sLA.tarif;
        }

        public override int GetHashCode()
        {
            int hashCode = 1818643590;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(slaID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + tarif.GetHashCode();
            return hashCode;
        }
    }
}
