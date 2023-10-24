using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Bank
{
    public class Bank
    {
        public string BankName { get; private set; }

        public Bank(string bankName)
        {
            BankName = bankName;
        }

        //создаем клиента 
        public Client.Client CreateClient(string clientName, int Id)
        {
            return new Bankomat.Client.Client(clientName, Id);
        }

    }
}

