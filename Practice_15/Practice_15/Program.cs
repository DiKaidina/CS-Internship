using Practice_15;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Task_1*/
        Type ClassType = typeof(MyClass);

        //конструкторы
        Console.WriteLine("Список конструкторов:");
        ConstructorInfo[] constructors = ClassType.GetConstructors();
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine($"Конструктор: {constructor.Name}");
        }

        //поля

        Console.WriteLine("Поля:");
        //BindingFlags.DeclaredOnly чтобы не выводил наследуемые от Object методы и поля
        //BindingFlags.NonPublic | BindingFlags.Instance чтобы выводил Private поля тоже
        FieldInfo[] fields = ClassType.GetFields(BindingFlags.DeclaredOnly| BindingFlags.NonPublic | BindingFlags.Instance);
    

        foreach (FieldInfo field in fields)
        {
            Console.WriteLine($"Поле: {field.Name}, Тип: {field.FieldType.Name}, Модификатор доступа: {field.Attributes}");
        }

        // Список методов
        Console.WriteLine("Методы:");
        MethodInfo[] methods = ClassType.GetMethods(BindingFlags.DeclaredOnly |BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"Метод: {method.Name}, тип: {method.ReturnType.Name}, Модификатор доступа: {method.Attributes}");
        }

        /*Task_2*/
        // Создание экземпляра MyClass без вызова конструктора
        object new_obj = Activator.CreateInstance(ClassType);

        var new_prop = ClassType.GetProperty("ЩУЗВЗУЗУ");
        new_prop.SetValue(new_obj, 1);

        // Вывод информации о состоянии объекта
        var state = ClassType.GetMethod("PublicMethod");
        state.Invoke(new_obj, null);

        /*Task_4*/

        // Вызов приватного метода
        var privateMethod = ClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        privateMethod.Invoke(new_obj, null);

    }
}