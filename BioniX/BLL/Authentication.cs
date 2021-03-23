using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_sen381_group15.BLL
{
    class Authentication
    {
        private string username;
        private string password;
        private List<Clients> Clients;

        public Authentication(string username, string password, List<Clients> clients)
        {
            this.username = username;
            this.password = password;
            Clients = clients;
        }

        public List<Clients> GetClients()
        {
            return null;
        }
        public bool ClientValidate(string username, string password)
        {
            return false;
        }
        public bool ClientExist(string username)
        {
            return false;
        }
    }
}
