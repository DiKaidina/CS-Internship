using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ServiceType { get; set; }

        public Client(int id, string name, string serviceType)
        {
            Id = id;
            Name = name;
            ServiceType = serviceType;  
        }
    }
}
