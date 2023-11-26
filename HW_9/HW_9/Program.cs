using HW_9;

internal class Program
{
    private static void Main(string[] args)
    {
        Manager manager = new Manager("Aboba Aboba", 40, 10000, 1500);

        Console.WriteLine("Manager:");
        manager.GetInfo();
        double managerAnnualSalary = manager.CalculateAnnualSalary();
        Console.WriteLine($"Annual Salary of Manager: {managerAnnualSalary}");
        Console.WriteLine();


        // Developer
        Developer developer = new Developer("QWERTY", 28, 60000, 200);

        Console.WriteLine("Developer:");
        developer.GetInfo();

        // Расчет и вывод годовой зарплаты с учетом оплаты за строки кода
        double developerAnnualSalary = developer.CalculateAnnualSalary();
        Console.WriteLine($"Annual Salary of Developer: {developerAnnualSalary}");
    }
}