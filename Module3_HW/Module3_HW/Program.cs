internal class Program

{
    static void Task_1()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static void Task_2()
    {
        int[] array = { 3, 7, 1, 9, 4, 6, 8, 2, 5 };

        int maxIndex = 0;
        int maxValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }

        Console.WriteLine("Индекс максимального значения: " + maxIndex);
    }

    static void Task_5()
    {
        int[] array = { 3, 7, 1, 9, 4, 6, 8, 2, 5 };
        int indexToRemove = 3; // Индекс элемента, который нужно удалить

        int[] newArray = new int[array.Length - 1]; // Создать новый массив на один элемент меньше

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != indexToRemove)
            {
                newArray[j] = array[i];
                j++;
            }
        }

        array = newArray;

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static void Task_6()
    {
        int[] array = { 3, 7, 1, 9, 4, 6, 8, 2, 5 };
        int elemToRemove = 7;

        int[] newArray = new int[array.Length - 1]; // Создать новый массив на один элемент меньше

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] != elemToRemove)
            {
                newArray[j] = array[i];
                j++;
            }
        }

        array = newArray;

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static void Task_7()
    {
        int[] array = { 3, 7, 1, 9, 4, 6, 8, 2, 5 };
        int indexToInsert = 5; 
        int elementToInsert = 50; 

        int[] newArray = new int[array.Length + 1]; 

        for (int i = 0, j = 0; i < newArray.Length; i++)
        {
            if (i == indexToInsert)
            {
                newArray[i] = elementToInsert;
            }
            else
            {
                newArray[i] = array[j]; 
                j++;
            }
        }

        array = newArray;
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static void Task_9()
    {
        string inputString = "Привет как дела?";
        char[] delim = { ' ', ',', '.', '!', '?' }; // Разделители слов

        string[] words = inputString.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        
        string resultString = "";

        foreach (string word in words)
        {
            if (!word.Contains('а'))
            {
                resultString += word + " ";
                
            }
        }

        resultString = resultString.Trim(); // Удалить лишние пробелы в конце

        Console.WriteLine(resultString);
    }
    static void Task_10()
    {
        string s = "Привет как дела?";
        char[] delim = { ' ', ',', '.', '!', '?' }; 

        string[] words = s.Split(delim, StringSplitOptions.RemoveEmptyEntries);

        string resultString = "";

        foreach (string word in words)
        {
            if (word.Length >= 2 && word[0] == word[word.Length - 1]) //строка = массив char
            {
                resultString += "[" + word + "] ";
            }
            else
            {
                resultString += word + " ";
            }
        }


        Console.WriteLine(resultString);
    }

    static void Task_12()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введите элементы матрицы:");

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write($"matrix[{row},{col}]: ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nИсходная матрица:");

        PrintMatrix(matrix);

        for (int col = 0; col < cols; col++)
        {
            if (matrix[col, col] % 2 == 0)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = 0;
                }
            }
        }

        Console.WriteLine("\nМатрица после обнуления элементов:");
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Task_14()
    {
        Console.WriteLine("Введите символы (для завершения введите точку):");

        int spaceCount = 0;

        while (true)
        {
            char inputChar = Console.ReadKey().KeyChar;

            if (inputChar == ' ')
            {
                spaceCount++;
            }
            else if (inputChar == '.')
            {
                break; // Выход из цикла при вводе точки
            }
        }

        Console.WriteLine("\nКоличество введенных пробелов: " + spaceCount);
    }

    static void Task_15()
    {
        Console.Write("Введите номер трамвайного билета (6-значное число): ");
        string ticket = Console.ReadLine();

        if (ticket.Length == 6)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < 3; i++)
            {
                sum1 += int.Parse(ticket[i].ToString());
                sum2 += int.Parse(ticket[i + 3].ToString());
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Этот билет счастливый!");
            }
            else
            {
                Console.WriteLine("Этот билет не счастливый.");
            }
        }
        else
        {
            Console.WriteLine("Номер билета должен быть шестизначным.");
        }
    }

    static void Task_18()
    {
        Console.Write("Введите число > 0 : ");
        int num = int.Parse(Console.ReadLine()); 

        if (num > 0)
        {
            string s = num.ToString();
            for (int i = s.Length - 1; i >= 0; i --)
            {
                Console.Write(s[i]);
            }

        }
        else
        {
            Console.WriteLine("Необходимо ввести положительное число");
        }
    }

    static void Task_21()
    {
        int[,] arr = new int[5, 5];
        Random random = new Random();

        // Заполняем массив случайными числами
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr[i, j] = random.Next(-100, 100 + 1);
            }
        }

        int minRowIndex = 0;
        int minColIndex = 0;
        int maxRowIndex = 0;
        int maxColIndex = 0;
        int minValue = arr[0, 0];
        int maxValue = arr[0, 0];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (arr[i, j] < minValue)
                {
                    minValue = arr[i, j];
                    minRowIndex = i;
                    minColIndex = j;
                }
                else if (arr[i, j] > maxValue)
                {
                    maxValue = arr[i, j];
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

        // Определяем границы интервала
        int startRow = Math.Min(minRowIndex, maxRowIndex);
        int endRow = Math.Max(minRowIndex, maxRowIndex);
        int startCol = Math.Min(minColIndex, maxColIndex);
        int endCol = Math.Max(minColIndex, maxColIndex);

        // Вычисляем сумму элементов внутри интервала
        int sum = 0;
        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                sum += arr[i, j];
            }
        }

        Console.WriteLine("Сумма элементов между минимальным и максимальным элементами: " + sum);
    
}
    static void Task_22()
    {
        Console.WriteLine("Введите строку ");
        string s = Console.ReadLine();

        string res = " ";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].ToString() != "/" ) {
                res += s[i];
            }

        }
        Console.WriteLine(res);
    }
    static void Task_23()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        int digitCount = CountDigits(inputString);

        Console.WriteLine("Количество цифр в строке: " + digitCount);
    }
    static int CountDigits(string inputString)
    {
        int digitCount = 0;

        foreach (char c in inputString)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        return digitCount;
    }

    static void Task_24()
    {
        Console.WriteLine("Введите строку");
        bool status = false;
        string s = Console.ReadLine();
        foreach(string word in s.Split(new char[] {' ' }))
        {
            if (word == "one")
            {
                status = true;
            }
        }

        if(status == true)
        {
            Console.WriteLine("Есть слово");
        }
        else
        {
            Console.WriteLine("Нет слова");
        }
    }
    private static void Main(string[] args)
    {   /*Напечатать весь массив целых чисел*/
        //Task_1();

        /*Найти индекс максимального значения в массиве*/
        //Task_2();

        /*Удалить элемент из массива по индексу*/
        //Task_5();

        /*Удаление элементов из массива по значению*/
        //Task_6();

        /*Вставить элемент в массив по индекс*/
        //Task_7();

        /*Удалить из строки слова, в которых есть буква 'a'*/
        //Task_9();

        /*В строке все слова, которые начинаются и заканчиваются одной буквой, выделить квадратными скобками*/
        //Task_10();

        /*Обнулить элементы тех столбцов, на пересечении которых с главной диагональю стоит четный элемент*/
        //Task_12();

        /*Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
         * Программа должна сосчитать количество введенных пользователем пробелов. (Подсказка. IF, Length)*/
        //Task_14();

        /*Счастливый билет*/
        //Task_15();

        /*Прочитать число наоборот*/
        //Task_18();

        /*Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
         * Определить сумму элементов массива, расположенных между минимальным и максимальным элементами*/
        //Task_21(); 

        /*Есть строка (любая), нужно удалить из этой строки знаки / и \.*/
        //Task_22();

        /*Написать программу, подсчитывающую количество цифр в заданной строке*/
        //Task_23();

        /*Дан текст. Определить, есть ли в тексте слово one*/

        //Task_24();

    }
}