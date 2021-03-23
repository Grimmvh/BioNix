using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class Agents:Staff
    {
        private string staffID;
        private string name;
        private string surname;
        private string status;
        private string[] skills;
        private string Adress;

        public Agents() { }

        public Agents(string staffID, string name, string surname, string status, string[] skills, string adress)
        {
            this.staffID = staffID;
            this.name = name;
            this.surname = surname;
            this.status = status;
            this.skills = skills;
            Adress = adress;
        }

        public string StaffID { get => staffID; set => staffID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Status { get => status; set => status = value; }
        public string[] Skills { get => skills; set => skills = value; }
        public string Adress1 { get => Adress; set => Adress = value; }

        public override bool Equals(object obj)
        {
            return obj is Agents agents &&
                   staffID == agents.staffID &&
                   name == agents.name &&
                   surname == agents.surname &&
                   status == agents.status &&
                   EqualityComparer<string[]>.Default.Equals(skills, agents.skills) &&
                   Adress == agents.Adress;
        }

        public override int GetHashCode()
        {
            int hashCode = -227589259;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(staffID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string[]>.Default.GetHashCode(skills);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Adress);
            return hashCode;
        }
    }
}
