
public class Program
{
    private static void Main(string[] args)
    {
        // Создание объектов
        Person.Person person = new Person.Person("John", "Smith");
        Student.Student student = new Student.Student("Diana", "Smith", 123, "Computer Science");
        Teacher.Teacher teacher = new Teacher.Teacher("Professor", "Johnson", "Math");

        // Тестирование ToString()
        Console.WriteLine(person.ToString());
        Console.WriteLine(student.ToString());
        Console.WriteLine(teacher.ToString());

        // Тестирование Equals()
        Student.Student student2 = new Student.Student("Diana", "Smith", 123, "Computer Science");
        Console.WriteLine($"Student Equals: {student.Equals(student2)}");

        // Тестирование GetHashCode()
        Console.WriteLine($"Student HashCode: {student.GetHashCode()}");
    }
}