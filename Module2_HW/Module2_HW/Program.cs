using System;

internal class Program
{
  
    static int Task_1(string str)
    {
        int count = 0;
        foreach (char i in str)
        {
            if (i == ' ')
            {
                count++;
            }
        }
        return count;
    }

    static string Task_5(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Task_6()
    {
        Random random = new Random();

        int num1 = random.Next(1, 100); 
        int num2 = random.Next(1, 100); 
        int num3 = random.Next(1, 100);

        Console.WriteLine($"{num1}  {num2}  {num3}");


    }

    static void Task_7()
    {
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 21;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }

    static void Task_8()
    {
        Console.WriteLine("Введите расстояние в сантиметрах:");
        double cm = double.Parse(Console.ReadLine());

        double m = cm / 100;

        Console.WriteLine("Число полных метров: " + m);

    }

    static void Task_9()
    {
        int days = 234; 

        int weeks = days / 7; 

        Console.WriteLine("За " + days + " дней прошло " + weeks + " полных недель");
    }
    
    static void Task_10()
    {
        Console.WriteLine("Введите двузначное число:");
        int num = int.Parse(Console.ReadLine());

        int tens = num / 10; 
        int ones = num % 10; 
        int sum = tens + ones; 
        int product = tens * ones; 

        Console.WriteLine("Число десятков: " + tens);
        Console.WriteLine("Число единиц: " + ones);
        Console.WriteLine("Сумма цифр: " + sum);
        Console.WriteLine("Произведение цифр: " + product);
    }

    static void Task_11()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        //  A или B
        bool res1 = A || B;
        Console.WriteLine("A или B = " + res1);

        //  A и B
        bool res2 = A && B;
        Console.WriteLine("A и B = " + res2);

        // B или C
        bool res3 = B || C;
        Console.WriteLine("B или C = " + res3);
    }

 
    static void Task_12()
    {
        Console.WriteLine("Введите радиус круга:");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите длину стороны квадрата:");
        double a = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * Math.Pow(radius, 2); // Площадь круга
        double squareArea = Math.Pow(a, 2);   // Площадь квадрата

        if (circleArea > squareArea)
        {
            Console.WriteLine("Площадь круга больше");
        }
        else if (circleArea < squareArea)
        {
            Console.WriteLine("Площадь квадрата больше");
        }
        else
        {
            Console.WriteLine("Площади равны.");
        }
    }

    static void Task_13()
    {
        Console.WriteLine("Введите массу первого тела (в килограммах):");
        double m1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите объем первого тела (в кубических метрах):");
        double V1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите массу второго тела (в килограммах):");
        double m2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите объем второго тела (в кубических метрах):");
        double V2 = double.Parse(Console.ReadLine());

        double p1 = m1 / V1; 
        double p2 = m2 / V2; 

        if (p1 > p2)
        {
            Console.WriteLine("Материал первого тела имеет большую плотность.");
        }
        else if (p1 < p2)
        {
            Console.WriteLine("Материал второго тела имеет большую плотность.");
        }
        else
        {
            Console.WriteLine("Плотности материалов равны.");
        }
    }

    static void Task_14()
    {
        Console.WriteLine("Введите напряжение на первом участке :");
        double U1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите сопротивление на первом участке:");
        double R1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите напряжение на втором участке:");
        double U2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите сопротивление на втором участке:");
        double R2 = double.Parse(Console.ReadLine());

        double I1 = U1 / R1; 
        double I2 = U2 / R2; 

        if (I1 < I2)
        {
            Console.WriteLine("Меньший ток протекает на первом участке.");
        }
        else if (I1 > I2)
        {
            Console.WriteLine("Меньший ток протекает на втором участке.");
        }
        else
        {
            Console.WriteLine("Токи равны.");
        }
    }
    static void Task_16()
    {
        Console.WriteLine("Введите значение x:");
        double x = double.Parse(Console.ReadLine());

        double y = 7 * x * x - 3 * x + 6;

        Console.WriteLine("Значение функции = " + y);
    }
    static void Task_17()
    {
        Console.WriteLine("Введите значение a:");
        double a = double.Parse(Console.ReadLine());

        double x = 12 * Math.Pow(a, 2) + 7 * a - 16;

        Console.WriteLine("Значение функции = " + x);
    }
    static void Task_18()
    {
        Console.WriteLine("Введите длину стороны квадрата:");
        double a = double.Parse(Console.ReadLine());

        double p = 4 * a; 

        Console.WriteLine("Периметр квадрата с стороной " + a + " равен " + p);
    }

    static void Task_19()
    {
        Console.WriteLine("Введите радиус окружности:");
        double radius = double.Parse(Console.ReadLine());

        double diameter = 2 * radius; 

        Console.WriteLine("Диаметр окружности с радиусом равен " + diameter);
    }
    static void Task_22()
    {
        Console.WriteLine("Введите первое целое число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");
        int num2 = int.Parse(Console.ReadLine());

        double averageArithmetic = (num1 + num2) / 2.0; // Среднее арифметическое
        double averageGeometric = Math.Sqrt(num1 * num2); // Среднее геометрическое

        Console.WriteLine("Среднее арифметическое: " + averageArithmetic);
        Console.WriteLine("Среднее геометрическое: " + averageGeometric);
    }

    static void Task_23()
    {
        Console.WriteLine("Введите массу тела:");
        double m = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите объем тела:");
        double v = double.Parse(Console.ReadLine());

        double p = m / v; 

        Console.WriteLine("Плотность составляет " + p);
    }

    static void Task_30()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе  число:");
        double num2 = double.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine(num1 + " больше, чем " + num2);
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num1 + " меньше, чем " + num2);
        }
        else
        {
            Console.WriteLine("Оба числа равны.");
        }
    }
    static void Task_32()
    {
        Console.WriteLine("Введите целое число:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " является четным.");
        }
        else
        {
            Console.WriteLine(number + " не является четным.");
        }

        if (number % 10 == 7)
        {
            Console.WriteLine(number + " оканчивается цифрой 7.");
        }
        else
        {
            Console.WriteLine(number + " не оканчивается цифрой 7.");
        }
    }
    static void Task_39()
    {
        int n = 10; 

        for (int i = 0; i < n; i++)
        {
            Console.Write("20 ");

        }

        Console.WriteLine();
    }
    private static void Main(string[] args)
        //20 задач на выбор из 43
    {   //каждая задача оформлена отдельной функцией, расскоментируйте вызовы

        /*Task_1
         Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
         Программа должна сосчитать количество введенных пользователем пробелов*/

        /*Console.WriteLine("Введите предложение, для завершения введите точку");
        string input = Console.ReadLine();

        int res1 = Task_1(input);
        Console.WriteLine("Количество пробелов: " + res1);
        */



        /*Task_2
         Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
         Например, если было введено число 345, то программа должна вывести число 543
        */

        /*Console.WriteLine("Введите трех и более значное число");
        int n = int.Parse(Console.ReadLine());

        string numberAsString = n.ToString();
        string reversedString = Task_5(numberAsString);

        int reversedNumber = int.Parse(reversedString);

        Console.WriteLine("Перевернутое число :" + reversedNumber);
        */



        /*Task_6
         Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
        */
        //Task_6();



        /*Task_7
         * Вывести на экран числа 5, 10 и 21 одно под другим*/
        //Task_7();



        /*Task_8
         Дано расстояние в сантиметрах. Найти число полных метров в нем
        */
        //Task_8();



        /*Task_9
         С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/
        //Task_9();



        /*Task_10
         Дано двузначное число. Найти: число десятков в нем, число единиц в нем, сумму его цифр, произведение его цифр*/

        //Task_10();


        /*Task_11
         Вычислить значение логического выражения при следующих значениях логических величин А, В и С: 
         А = Истина, В = Ложь, С = Ложь*/

        //Task_11();

        /*Task_12
         Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?*/

        //Task_12();


        /*Task_13
         Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
        */
        //Task_13();


        /*Task_14
         Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них.
        По какому участку протекает меньший ток?*/

        //Task_14();


        /*Task_16*/
        /*вычисления значения функции y= 7x2-3x+6 при любом значении x*/
        //Task_16();

        /*Task_17*/
        /*вычисления значения функции x= 12a2+7a-16 при любом значении а.*/
        //Task_17();

        /*Task_18
         Дана сторона квадрата. Найти его периметр*/
        //Task_18();

        /*Task_19
         Дан радиус окружности. Найти ее диаметр*/

        //Task_19();

        /*Task_22
         Даны два целых числа. Найти:их среднее арифметическое, среднее геометрическое*/

        //Task_22();

        /*Task_23
         Известны объем и масса тела. Определить плотность материала этого тел*/
        //Task_23();

        /*Task_30
         30. Даны два различных вещественных числа. Определить: какое из них больше/какое из них меньше*/
        //Task_30();

        /*Task_32
         Дано натуральное число. Определить: является ли оно четным, оканчивается ли оно цифрой 7*/
        //Task_32();

        /*Task_39
         Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20*/
        //Task_39();
    }
}
