using System;

// Интерфейс для описания свойств сотрудника
public interface IEmployee
{
    string Name { get; set; }
    int Age { get; set; }
    double Salary { get; set; }
    string Position { get; set; }
    DateTime HireDate { get; set; }

    void Display();
}

// Структура, реализующая интерфейс IEmployee
public struct Employee : IEmployee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public DateTime HireDate { get; set; }

    public Employee(string name, int age, double salary, string position, DateTime hireDate)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Position = position;
        HireDate = hireDate;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}, Position: {Position}, HireDate: {HireDate.ToShortDateString()}");
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Salary: {Salary}, Position: {Position}, HireDate: {HireDate.ToShortDateString()}";
    }
}




class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        Employee[] employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter information for employee {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Position: ");
            string position = Console.ReadLine();
            Console.Write("Hire date (yyyy-mm-dd): ");
            DateTime hireDate = DateTime.Parse(Console.ReadLine());

            employees[i] = new Employee(name, age, salary, position, hireDate);
        }

        DisplayAll(employees);

        DisplayManagerSalary(employees);

        Console.Write("\nEnter a date for filtering (yyyy-mm-dd): ");
        DateTime filterDate = DateTime.Parse(Console.ReadLine());
        DisplayHiredAfterDate(employees, filterDate);

        Console.Write("\nEnter gender for filtering (M/F), or leave blank for all: ");
        string genderFilter = Console.ReadLine();
        DisplayByGender(employees, genderFilter);
    }

    static void DisplayAll(Employee[] employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }

    static double GetAvgClerksSalary(Employee[] employees)
    {
        double totalSalary = 0;
        int clerksCount = 0;

        foreach (var employee in employees)
        {
            if (employee.Position.ToLower() == "clerk")
            {
                totalSalary += employee.Salary;
                clerksCount++;
            }
        }

        return clerksCount > 0 ? totalSalary / clerksCount : 0;
    }

    static void DisplayManagerSalary(Employee[] employees)
    {
        double avgClerksSalary = GetAvgClerksSalary(employees);
        Console.WriteLine($"\nManagers with salary above clerks' average salary:");

        foreach (var employee in employees)
        {
            if (employee.Position.ToLower() == "manager" && employee.Salary > avgClerksSalary)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }

    static void DisplayHiredAfterDate(Employee[] employees, DateTime filterDate)
    {
        Array.Sort(employees, (x, y) => string.Compare(x.Name, y.Name));

        Console.WriteLine($"\nEmployees hired after {filterDate.ToShortDateString()}:");

        foreach (var employee in employees)
        {
            if (employee.HireDate > filterDate)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }

    static void DisplayByGender(Employee[] employees, string genderFilter)
    {
        Console.WriteLine("\nEmployees by gender:");

        foreach (var employee in employees)
        {
            if (string.IsNullOrWhiteSpace(genderFilter) ||
                (genderFilter.ToUpper() == "M" && (employee.Name.EndsWith("ov") || employee.Name.EndsWith("ev"))) ||
                (genderFilter.ToUpper() == "F" && !employee.Name.EndsWith("ov") && !employee.Name.EndsWith("ev")))
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}