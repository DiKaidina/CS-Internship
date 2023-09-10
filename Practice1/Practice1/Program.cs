internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше ФИО");
        string username = Console.ReadLine();

        Console.WriteLine("Приветству вас," + username + "!");

        //Ввод нескольких чисел и их сумма

        Console.WriteLine("Введите числа через пробел:");
        string input_nums = Console.ReadLine();

        double sum = CalcSum(input_nums);

        Console.WriteLine($"Сумма чисел: {sum}");


    }
    static double CalcSum(string input)
    {
        double sum = 0;
        string[] numbers = input.Split(' ');

        foreach (string num in numbers)
        {
            //TryParse по умолчанию не генерирует исключения
            if (double.TryParse(num, out double number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine($"Ошибка: '{num}' не число!");
            }
        }

        return sum;
    }
 }
