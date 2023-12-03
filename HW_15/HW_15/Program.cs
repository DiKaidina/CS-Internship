using HW_15;
using System.Reflection; //использование рефлексии

public class Program
{
    private static void Main(string[] args)
    {
        /*Task_1*/
        /*
        Type ConsoleType = typeof(Console);
        MethodInfo[] methods = ConsoleType.GetMethods();

        Console.WriteLine($"Методы класса Console:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"Метод :{method.Name}"); 

        }*/

        /*Task_2*/
        Console.WriteLine($"Task_2");
        Person person = new Person("Diana", "Kaidina", 30);
        Type personType = typeof(Person);

        // Получение свойств класса Person
        PropertyInfo[] properties = personType.GetProperties();

        Console.WriteLine($"Свойства класса Person и их значения:");

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(person);
            Console.WriteLine($"{property.Name}: {value}");
        }


        /*Task_3*/
        Console.WriteLine($"Task_3");
        string str = "Меня зовут Боб";
        Type stringType = typeof(string);

        
        MethodInfo substr = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

        if (substr != null)
        {
            // Параметры для вызова метода Substring
            object[] parameters = { 4, 6 }; 

           
            object result = substr.Invoke(str, parameters);

            // Вывод результата на экран
            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Полученная подстрока: {result}");
        }


        /*Task_4*/
        Type listType = typeof(List<>);

        ConstructorInfo[] constructors = listType.GetConstructors();

        Console.WriteLine($"Конструкторы класса List<T>:");

        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine($"Конструктор : {constructor}");
        }
    }
}