using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public class Manager : Employee
    {
        private double bonus = 0;

        public Manager(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            this.bonus = bonus; 

        }

        public override double CalculateAnnualSalary()
        {
            double baseSalary = base.CalculateAnnualSalary();
            return baseSalary + bonus * 12;
        }

    }
}
