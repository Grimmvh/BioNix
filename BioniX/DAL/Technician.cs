using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class Technician:Staff
    {

        private string staffID;
        private string name;
        private string surname;
        private string status;
        private string[] skills;
        private string Adress;

        public Technician() { }
        public Technician(string staffID, string name, string surname, string status, string[] skills, string adress)
        {
            this.StaffID = staffID;
            this.Name = name;
            this.Surname = surname;
            this.Status = status;
            this.Skills = skills;
            Adress1 = adress;
        }

        public string StaffID { get => staffID; set => staffID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Status { get => status; set => status = value; }
        public string[] Skills { get => skills; set => skills = value; }
        public string Adress1 { get => Adress; set => Adress = value; }

        public override bool Equals(object obj)
        {
            return obj is Technician technician &&
                   StaffID == technician.StaffID &&
                   Name == technician.Name &&
                   Surname == technician.Surname &&
                   Status == technician.Status &&
                   EqualityComparer<string[]>.Default.Equals(Skills, technician.Skills) &&
                   Adress1 == technician.Adress1;
        }

        public override int GetHashCode()
        {
            int hashCode = -227589259;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StaffID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string[]>.Default.GetHashCode(Skills);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Adress1);
            return hashCode;
        }
    }
}
