using Practice_8;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task_1
        RangeOfArray customArray = new RangeOfArray(-1, 10);

        for (int i = -1; i <= 10; i++)
        {
            customArray[i] = i; // Заполняем массив квадратами чисел от 6 до 10
        }

        for (int i = -1; i <= 10; i++)
        {
            Console.WriteLine($"customArray[{i}] = {customArray[i]}");
        }

        //Task_2

        Supermarket supermarket = new Supermarket();
        bool isdiscount;
        // Получаем час покупки от пользователя
        Console.Write("Введите час покупки (от 0 до 23): ");
        if (!int.TryParse(Console.ReadLine(), out int purchaseHour) || purchaseHour < 0 || purchaseHour > 23)
        {
            Console.WriteLine("Неверное значение часа покупки.");
            return;
        }

        // Выводим информацию о продуктах и их ценах с использованием индексатора
        Console.WriteLine("Продукты в магазине:");
        for (int i = 0; i < supermarket.products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {supermarket.products[i]} - {supermarket[i]} тнг.");
        }

        // Выбор продуктов
        Console.WriteLine("Выберите продукты (указывайте номера через пробел):");
        string[] selectedProducts = Console.ReadLine().Split(' ');

        int[] selectedProductIndexes = new int[selectedProducts.Length];
        for (int i = 0; i < selectedProducts.Length; i++)
        {
            if (int.TryParse(selectedProducts[i], out int index))
            {
                selectedProductIndexes[i] = index - 1;
            }
            else
            {
                Console.WriteLine($"Неверный номер продукта: {selectedProducts[i]}");
                return;
            }
        }

        if (purchaseHour >= 8 && purchaseHour <= 14)
        {
            isdiscount = true;
        }
        else
            isdiscount = false;

        double totalAmount = supermarket.TotalAmount(selectedProductIndexes, isdiscount);

        Console.WriteLine($"Общая сумма: {totalAmount} тенге.");
    }
}