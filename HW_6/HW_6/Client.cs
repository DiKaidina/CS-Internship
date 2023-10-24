using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Client
{
    public class Client
    {
        private string ClientName;
        private int ClientId;

     
        public Client(string ClientName, int ClientId)
        {
            this.ClientName = ClientName;
            this.ClientId = ClientId;   
        }

        public string GetClientInfo()
        {
            return ClientName; 
        }
        //создаем счет 
        public Bankomat.Account.Account OpenAccount(string accountNumber, decimal Balance, string password)
        {
            return new Bankomat.Account.Account(accountNumber, Balance, password);
        }

    }
}
