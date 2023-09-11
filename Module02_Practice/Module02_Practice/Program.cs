internal class Program
{
    static void Task_10()
    {
        Console.WriteLine("целые числа от 20 до 35:");
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }

        Console.Write("\nВведите значение b > 10: ");
        int b = int.Parse(Console.ReadLine());

        if (b <= 10)
        {
            Console.WriteLine("Должно быть больше 10");
            return;
        }
        Console.WriteLine("\n Квадраты всех целых чисел от 10 до b:");
        for (int i = 10; i <= b; i++)
        {
            int square = (int)Math.Pow(i, 2);
            Console.WriteLine(square);
        }

        Console.Write("\nВведите значение a < 50: ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 50)
        {
            Console.WriteLine("Значение a должно быть меньше 50.");
            return;
        }

        Console.WriteLine("\nc. Третьи степени всех целых чисел от " + a + " до 50:");
        for (int i = a; i <= 50; i++)
        {
            int cube = (int)Math.Pow(i, 3);
            Console.WriteLine(cube);
        }

        Console.Write("\nВведите значение b > a: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= a)
        {
            Console.WriteLine("Значение b должно быть больше a.");
            return;
        }

        Console.WriteLine("\nd. Все целые числа от " + a + " до " + num + ":");
        for (int i = a; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Task_12()
    {
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());

        
        double L = 2 * Math.PI * radius;

        // Расчет площади круга
        double S = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Длина окружности: {L}");
        Console.WriteLine($"Площадь круга: {S}");
    }

    static void Task_16()
    {
        Console.Write("Введите четырехзначное число: ");
        int num = int.Parse(Console.ReadLine());

        // Проверка, что введено четырехзначное число
        if (num < 1000 || num > 9999)
        {
            Console.WriteLine("Введено не четырехзначное число");
            return;
        }

        
        int thousands = num / 1000;
        int hundreds = (num / 100) % 10;
        int tens = (num / 10) % 10;
        int ones = num % 10;

        
        int sum = thousands + hundreds + tens + ones;

        
        int proizv = thousands * hundreds * tens * ones;

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {proizv}");
    }

    static void Task_17()
    {
        int num = 456;
        int hundreds = num / 100;
        int tens = (num / 10) % 10;
        int ones = num % 10;

        int new_num = hundreds*100 + 10 * ones + tens;
        Console.WriteLine($"Старое число = {new_num}");
    }
    static void Task_18()
    {
        Console.Write("Введите значение X (0 или 1): ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Введите значение Y (0 или 1): ");
        int Y = int.Parse(Console.ReadLine());

        if (X != 0 && X != 1 || Y != 0 && Y != 1)
        {
            Console.WriteLine("Пожалуйста, введите 0 или 1 для X и Y.");
            return;
        }

        //Если x == 1 то true
        bool boolX = (X == 1);
        bool boolY = (Y == 1);

        Console.WriteLine("a. не X и не Y:");
        bool resultA = !boolX && !boolY;
        Console.WriteLine($"Результат: {resultA}");

        Console.WriteLine("\nb. X или (не X и Y):");
        bool resultB = boolX || (!boolX && boolY);
        Console.WriteLine($"Результат: {resultB}");

        Console.WriteLine("\nc. (не X и Y) или Y:");
        bool resultC = (!boolX && boolY) || boolY;
        Console.WriteLine($"Результат: {resultC}");
    }

    static void Swap(ref int a, ref int b)
    {
        //через временную переменную
        int temp = a;
        a = b;
        b = temp;
    }

    static void Task_21(ref double a, ref double b, double x, double y)
    {
        a = x * y;
        if (y != 0)
        {
            b = x / y;
        }
        else
        {
            Console.WriteLine("y Не иожет быть равным 0!");
        }
    }
    public static int Task_22(int x, int y)
    {
        if (x == 0 && y == 0)
        {
            return 0;
        }
        else if (y == 0)
        {
            return 12 / x;
        }
        else if (x == 0)
        {
            return 12 / y;
        }
        else
        {
            return 144 / (x * y);
        }
    }

     static void Task_23()
    {
        Console.Write("Введите часы: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите секунды: ");
        int s= int.Parse(Console.ReadLine());

        if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
        {
            throw new ArgumentException("Неправильное значение времени.");
        }

        
        int Seconds = h * 3600 + m * 60 + s;
        Console.WriteLine("Секунд с начала дня " + Seconds); 
    }
    static int Task_24(int m, int d)
    {
        
        if (m < 1 || m > 12 || d < 1 || d > 30)
        {
            throw new ArgumentException("Некорректное значение месяца или дня.");
        }

        
        int days = 30 * (m - 1) + d;
        return days;
    }
    static int Task_25(int m, int d)
    {
        if (m < 1 || m > 12 || d < 1 || d > 31)
        {
            throw new ArgumentException("Некорректное значение месяца или дня.");
        }

        // Вычисление количества дней с начала года
        int days = (m - 1) * 30 + Math.Min(d, 31);
        return days;
    }
    public static bool Task_27(int n)
    {
        // Используем оператор % для определения четности числа
        // Если n делится на 2 без остатка, то оно четное, иначе - нечетное
        return n % 2 == 0;
    }
    static void Task_28()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        int min = num1; // Пусть num1 будет начальным минимальным значением

        if (num2 < min)
        {
            min = num2;
        }

        if (num3 < min)
        {
            min = num3;
        }

        Console.WriteLine("Наименьшее число: " + min);
    }

    static void Task_29()
    {
        Random rand = new Random();
        int rating = rand.Next(2, 6);
        string desc;

        switch (rating)
        {
            case 2:
                desc = "Неуд";
                break;
            case 3:
                desc = "Удовл";
                break;
            case 4:
                desc = "Хорошо";
                break;
            case 5:
                desc = "Отлично";
                break;
            default:
                desc = "Некорректная оценка";
                break;
        }
        Console.WriteLine("Итоговая оценка :" + desc);
    }
    private static void Main(string[] args)
    {   //Часть задач практики уже решена в домашней работе
        //Здесь будут нерешенные задачи 

        //Task_10();


        /* Task_12
         * Дан радиус окружности. Найти длину окружности и площадь круга.*/
        //Task_12();

        /*Task_16
         Дано четырехзначное число. Найти:
            a. сумму его цифр;
            b. произведение его цифр*/
        //Task_16();

        /*Task_17
         В трехзначном числе x зачеркнули его вторую цифру.
        Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456.
        Найти число x.*/

        //Task_17();


        /*Task_18
        Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
        a. не X и не Y;
        b. X или (не X и Y);
        c. (не X и Y) или Y*/

        //Task_18();

        /*Task_19
         Напишите функцию swap(int* a, int* b), которая изменяет значения параметров a и b так, что новое значение a рав-
        но старому значению b и наоборот*/

        /*Console.WriteLine("Введите число а:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число b:");
        int b = int.Parse(Console.ReadLine());

        Swap(ref a, ref b);
        Console.WriteLine($"После обмена: a = {a}, b = {b}");
        */


        /*Task_21
         Напишите функцию int f(int& a, int& b, int x, int y), которая присваивает объекту a значение, равное x*y, а объекту b значение x/y*/
        /*double a = 0;
        double b = 0;
        Console.WriteLine("Введите число x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число y:");
        double y = double.Parse(Console.ReadLine());

        Task_21(ref a, ref b, x, y);
        Console.WriteLine($"После преобразования: a = {a}, b = {b}");
        */


        /*Task_22*/
        /*Console.WriteLine("Введите число x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число y:");
        double y = double.Parse(Console.ReadLine());

        int result = Task_22(x, y);

        Console.WriteLine("Результат: " + result);
        */

        /*Task_23*/
        //Task_23();


        /*Task_24*/
        /*Console.WriteLine("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите день (1-30): ");
        int day = int.Parse(Console.ReadLine());
        int days = Task_24(month, day);
        Console.WriteLine("Дней с начала года: " + days);
        */

        /*Task_25*/
        /*
        Console.WriteLine("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите день (1-30): ");
        int day = int.Parse(Console.ReadLine());
        int days = Task_25(month, day);
        Console.WriteLine("Дней с начала года: " + days);
        */

        /*Task_27*/

        /*Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        bool isEven = Task_27(number);

        if (isEven)
        {
            Console.WriteLine("четное");
        }
        else
        {
            Console.WriteLine("нечетное");
        }
        */


        /*Task_28*/
        //Task_28();


        /*Task_29*/
        //Task_29();

    }


}