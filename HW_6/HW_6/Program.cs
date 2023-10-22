
using Bankomat.Account;
using Bankomat.Bank;
using Bankomat.Client;
using ClassLibrary;
using System;
using System.Security.Principal;

internal class Program
{

    public static void Login(Bankomat.Account.Account account)
    {
        string correctPassword = account.GetPassword();
        int max_attempts = 3;
        int cnt = 0;

        for (int attempts = 0; attempts < max_attempts; attempts++)
        {
            Console.Write("Введите пароль от счета: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == correctPassword)
            {
                Console.WriteLine("Пароль принят. Доступ разрешен.");
                Menu(account);  
                break;
            }
            else
            {
                Console.WriteLine($"Неверный пароль. Осталось попыток: {max_attempts - attempts - 1}");
                cnt = cnt + 1;
            }


        }

        if (cnt == max_attempts)
        {
            Console.WriteLine("Попытки исчерпаны. Доступ к счету запрещен.");
        }
    }

    public static void Menu(Bankomat.Account.Account account)
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("a. Вывести баланс");
            Console.WriteLine("b. Пополнить счет");
            Console.WriteLine("c. Снять деньги со счета");
            Console.WriteLine("d. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    decimal balance = account.GetBalance(); // Вызываем метод GetBalance
                    Console.WriteLine($"Баланс: {balance}");
                    break;

                case "b":
                    Console.Write("Введите сумму для пополнения: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        account.RefillAccount(depositAmount);
                        Console.WriteLine("Счет успешно пополнен.");
                        decimal balance1 = account.GetBalance(); // Вызываем метод GetBalance
                        Console.WriteLine($"Баланс: {balance1}");

                    }
                    else
                    {
                        Console.WriteLine("Некорректная сумма.");
                    }
                    break;

                case "c":
                    Console.Write("Введите сумму для снятия: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                    {
                        account.GetMoney(withdrawalAmount);
                        Console.WriteLine("Деньги успешно сняты со счета.");
                        decimal balance2 = account.GetBalance(); // Вызываем метод GetBalance
                        Console.WriteLine($"Баланс: {balance2}");
                    }

                    break;

                case "d":
                    return;

                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте ещё раз.");
                    break;
            }
        }
    }
    private static void Main(string[] args)
    {
        //Task_1
        ClassLibrary.Person person = new ClassLibrary.Person
        {
            FirstName = "Diana",
            LastName = "Kaidina"
        };

        string personInfo = PersonInfo.GetPersonInfo(person);

        Console.WriteLine(personInfo);

        //Task_2 - вывести все константы
        Console.WriteLine(Constants.str);
        Console.WriteLine(Constants.num);

        //Task_3
        /*клиенту нужно открыть счёт в банке, получить номер счёта, получить свой пароль, положить сумму на счёт*/

        Bankomat.Bank.Bank bank = new Bankomat.Bank.Bank("Aboba Bank");
        Bankomat.Client.Client client = bank.CreateClient("Иванов Иван", 1);

        Bankomat.Account.Account account = client.OpenAccount("12345", 2000, "password_12345");


        Console.WriteLine($"Номер счёта: {account.GetAccountNumber()}");
        Console.WriteLine($"Текущий баланс: {account.GetBalance()}");
        account.RefillAccount(500);
        Console.WriteLine($"Новый баланс: {account.GetBalance()}");
        Console.WriteLine($"Пароль: {account.GetPassword()}");


        //Task_4

        Login(account);


    }
}