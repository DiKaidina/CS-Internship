
// делегат MathOperation
public delegate double MathOperation(double x, double y);
public class Program
{
    private static void Main(string[] args)
    {

        double num1 = 10;
        double num2 = 5;

        Console.WriteLine($"Сложение: {PerformOperation(num1, num2, Summ)}");
        Console.WriteLine($"Вычитание: {PerformOperation(num1, num2, Subtract)}");
        Console.WriteLine($"Умножение: {PerformOperation(num1, num2, Multiply)}");
        Console.WriteLine($"Деление: {PerformOperation(num1, num2, Divide)}");


        /*анонимные делегаты*/
        MathOperation addSummNew = delegate (double x, double y) { return x + y; };

        /*лямбда выражения*/
        MathOperation subtractDelegate = (x, y) => x - y;
        MathOperation multiplyDelegate = (x, y) => x * y;


        //цепочка делегатов
        MathOperation chainedDelegate = addSummNew + subtractDelegate + multiplyDelegate;
        Console.WriteLine($"Цепочка делегатов: {chainedDelegate(num1, num2)}");

    }

    // Методы для выполнения арифметических операций
    static double Summ(double x, double y) => x + y;
    static double Subtract(double x, double y) => x - y;
    static double Multiply(double x, double y) => x * y;
    static double Divide(double x, double y) => y != 0 ? x / y : double.NaN;

    // Метод для выполнения операции с использованием делегата
    static double PerformOperation(double x, double y, MathOperation operation) //объявили экземпляр самого делегата
    {
        return operation(x, y);
    }
}

