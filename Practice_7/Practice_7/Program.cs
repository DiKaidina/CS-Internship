using Practice_7;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task_1 and Task_2
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] array3 = { 1, 2, 3 };

        Cat cat1 = new Cat(array1, "Fluffy", 12);
        Cat cat2 = new Cat(array2, "Anderson", 4);
        Cat cat3 = new Cat(array1, "Fluffy", 12);

        bool isEqual = cat1 == cat2;
        bool isNotEqual = cat1 != cat2;
        bool isEqual2 = cat1 == cat3;

        Console.WriteLine(isEqual);
        Console.WriteLine(isNotEqual);
        Console.WriteLine(isEqual2);

        bool result1 = cat1 < cat2; 
        bool result2 = cat1 > cat2; 
        bool result3 = cat1 == cat3;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);


        //Task_3
        Money money1 = new Money(100, "USD");
        Money money2 = new Money(75, "USD");
        Money money3 = new Money(100, "EUR");

        Converter converter = new Converter();

        //Сложение в одной валюте 
        Money convertedMoney = converter.Convert(money3, "USD", 2); // Convert EUR to USD
        Console.WriteLine($"Converted Money: {convertedMoney.Amount} {convertedMoney.Currency}");

        // Пример сложения сумм в одной валюте
        Money totalMoney = converter.Add(money1, money2); // Сложение в USD
        Console.WriteLine($"Total Money: {totalMoney.Amount} {totalMoney.Currency}");

        //В разных валютах 
        try
        {
            Money Example_invalid= converter.Add(money1, money3); 
            Console.WriteLine($" Total Money: {Example_invalid.Amount} {Example_invalid.Currency}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }


    }
}