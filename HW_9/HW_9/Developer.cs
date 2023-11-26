using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public class Developer : Employee
    {
        private int linesOfCodePerDay;
        public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {
            double baseSalary = base.CalculateAnnualSalary(); // вызов метода базового класса
            double PaymentPerLine = 0.01;
            double AnnualBonusPerCode = PaymentPerLine * 30 * 12;
            return baseSalary + AnnualBonusPerCode;
        }
    }
}
