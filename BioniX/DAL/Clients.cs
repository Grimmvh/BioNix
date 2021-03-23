using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15
{
    class Clients
    {
        private string clientID;
        private string name;
        private string surname;
        private string nationalID;
        private string phoneNumber;
        private string email;
        private string Adress;

        public Clients(){ }
        public Clients(string clientID, string name, string surname, string nationalID, string phoneNumber, string email, string adress)
        {
            this.ClientID = clientID;
            this.Name = name;
            this.Surname = surname;
            this.NationalID = nationalID;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            Adress1 = adress;
        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string NationalID { get => nationalID; set => nationalID = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Adress1 { get => Adress; set => Adress = value; }

        public override bool Equals(object obj)
        {
            return obj is Clients clients &&
                   ClientID == clients.ClientID &&
                   Name == clients.Name &&
                   Surname == clients.Surname &&
                   NationalID == clients.NationalID &&
                   PhoneNumber == clients.PhoneNumber &&
                   Email == clients.Email &&
                   Adress1 == clients.Adress1;
        }

        public override int GetHashCode()
        {
            int hashCode = 318382981;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NationalID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Adress1);
            return hashCode;
        }
    }
}
