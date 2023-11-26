using System;

public enum Vacancies
{
    Manager,
    Programmer,
    Engineer, 
    HR
}

public struct Employee
{
    public string Name;
    public Vacancies Vacancy;
    public int[] HireDate; 
    public int Salary;

    public Employee(string name, Vacancies vacancy, int[] hireDate, int salary)
    {
        Name = name;
        Vacancy = vacancy;
        HireDate = hireDate;
        Salary = salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Vacancy: {Vacancy}, Hire Date: {GetDate()}, Salary: {Salary}");
    }

    private string GetDate()
    {
        return $"{HireDate[0]}-{HireDate[1]}-{HireDate[2]}";
    }
}

class Program
{
    static void Main()
    {
        // Пример использования структуры Employee
        Employee employee1 = new Employee("Diana Kaidina", Vacancies.Manager, new int[] { 2020, 09, 07 }, 50000);
        Employee employee2 = new Employee("aboba aboba", Vacancies.HR, new int[] { 2022, 11, 26 }, 30000);

        Console.WriteLine("Employee:");
        employee1.PrintInfo();

        Console.WriteLine("\nEmployee:");
        employee2.PrintInfo();
    }
}