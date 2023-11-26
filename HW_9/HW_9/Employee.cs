using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    public class Employee
    {
        private string name;
        private int age;
        private double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Employee name: {name}, Employeem Age: {age}, Employee Salary: {salary}");
        }

        public virtual double CalculateAnnualSalary()
        {
            const double taxRate = 0.2; // 20% налог
            double AnnualSalary = salary* 12 * (1 - taxRate);
            return AnnualSalary;
        }


    }
}
