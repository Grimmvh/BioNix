using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class Registration
    {
        private string username;
        private string password;
        private string name;
        private string surname;
        private string nationalID;
        private string phoneNumber;
        private string eMail;
        private string adress;
        private string client;

        public Registration(string username, string password, string name, string surname, string nationalID, string phoneNumber, string eMail, string adress, string client)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.nationalID = nationalID;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
            this.adress = adress;
            this.client = client;
        }
        public Registration() { }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is Registration registration &&
                   username == registration.username &&
                   password == registration.password &&
                   name == registration.name &&
                   surname == registration.surname &&
                   nationalID == registration.nationalID &&
                   phoneNumber == registration.phoneNumber &&
                   eMail == registration.eMail &&
                   adress == registration.adress &&
                   client == registration.client;
        }
        public Clients CreateClient(string username, string password, string name, string surname, string nationalID, string phoneNumber, string eMail, string adress, string client)
        {
            return null;
        }
        public bool ClientValidate(string client)
        {
            return false;
        }
        public bool ClientExists(string client)
        {
            return false;
        }
        public bool RegisterClient(string client)
        {
            return false;
        }
    }
}
