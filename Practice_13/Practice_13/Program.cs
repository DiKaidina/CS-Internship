internal class Program
{
    static int GetSecondMaxIndex(List<int> list)
    {
        int maxIndex = 0;
        int secondMaxIndex = -1;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] > list[maxIndex])
            {
                secondMaxIndex = maxIndex;
                maxIndex = i;
            }
            else if (secondMaxIndex == -1 || list[i] > list[secondMaxIndex])
            {
                secondMaxIndex = i;
            }
        }

        return secondMaxIndex;
    }

    static List<int> ReadFile(string filePath)
    {
        try
        {
            // Чтение чисел из файла
            string[] lines = File.ReadAllLines(filePath);
            List<int> numbers = lines.Select(int.Parse).ToList();

            return numbers;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка чтения из файла: {ex.Message}");
            return new List<int>();
        }
    }

    static void WriteToFile(string filePath, List<int> numbers)
    {
        try
        {
            // Запись чисел в файл
            File.WriteAllLines(filePath, numbers.Select(n => n.ToString()));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка записи в файл: {ex.Message}");
        }
    }

private static void Main(string[] args)
    {

        /*Task_1*/
        List<int> numbers = new List<int> { 3, 7, 1, 8, 4, 9, 2, 5, 6 };

        // Вывод индекса и значения второго максимального элемента
        int secondMaxIndex = GetSecondMaxIndex(numbers);
        Console.WriteLine($"Позиция второго максимального элемента: {secondMaxIndex}");
        Console.WriteLine($"Значение второго максимального элемента: {numbers[secondMaxIndex]}");

        // Удаление всех нечетных элементов
        numbers.RemoveAll(n => n % 2 != 0);

        // Вывод коллекции после удаления нечетных элементов
        Console.WriteLine("Коллекция после удаления нечетных элементов:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }





        /*Task_2*/
        List<double> numbers2 = new List<double> { 3.5, 7.2, 1.8, 8.6, 4.2, 9.1, 2.4, 5.7, 6.3 };

        // Вычисление среднего арифметического
        double average = numbers2.Average();

        // Вывод элементов, которые больше среднего арифметического
        Console.WriteLine("Элементы больше среднего арифметического:");
        foreach (double number in numbers2.Where(n => n > average))
        {
            Console.Write(number + " ");
        }



        /*Task_3*/
        string SourceFile = "Practice_13/SourceFile.txt";

        // Путь к файлу, в который будут записаны числа в обратном порядке
        string DestFile = "Practice_13/DestFile.txt";


        List<int> numbers3 = ReadFile(SourceFile);

        // Переворачивание чисел
        numbers3.Reverse();

        // Запись чисел в обратном порядке в новый файл
        WriteToFile(DestFile, numbers3);

        Console.WriteLine("Процесс завершен.");

    }
}