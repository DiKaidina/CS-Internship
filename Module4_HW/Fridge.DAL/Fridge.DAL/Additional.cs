using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge.DAL
{
    public partial class Fridge
    {

        public void PrintInfo()
        {
            Console.WriteLine($"FridgeName {FridgeName}");
            Console.WriteLine($"FridgeVersion {FridgeVersion}");
            Console.WriteLine($"FridgeGuaranteeTerm {Guarantee_Term}");
        }
    }
}
