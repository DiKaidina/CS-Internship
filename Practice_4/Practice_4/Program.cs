using Practice_4;

internal class Program
{
    //объявила static для метода 
    public static Student[] Students = new Student[10];
    private static void Main(string[] args)
    {
        //Класс студент

        
        Students[0] = new Student { Name = "Anna", Group = 1, Grades = new int[] { 4, 5, 4, 5, 3 } };
        Students[1] = new Student { Name = "Andrey", Group = 1, Grades = new int[] { 5, 5, 4, 5, 5 } };
        Students[2] = new Student { Name = "Boris", Group = 2, Grades = new int[] { 4, 4, 4, 4, 4 } };
        Students[3] = new Student { Name = "Valentina", Group = 2, Grades = new int[] { 5, 5, 5, 5, 5 } };
        Students[4] = new Student { Name = "Gleb", Group = 2, Grades = new int[] { 3, 3, 3, 3, 3 } };
        Students[5] = new Student { Name = "Denis", Group = 3, Grades = new int[] { 4, 4, 5, 4, 4 } };
        Students[6] = new Student { Name = "Dimooon", Group = 3, Grades = new int[] { 3, 3, 3, 4, 4 } };
        Students[7] = new Student { Name = "Dilshat", Group = 4, Grades = new int[] { 5, 4, 5, 4, 4 } };
        Students[8] = new Student { Name = "Lala", Group = 4, Grades = new int[] { 5, 5, 5, 5, 5 } };
        Students[9] = new Student { Name = "Dancin Queen", Group = 4, Grades = new int[] { 4, 4, 4, 4, 4 } };

        // Вызываем метод для вывода студентов с хорошими оценками
        Students[0].WithGoodGrades();
        



        HomeLibrary library = new HomeLibrary();

        // Добавление книг в библиотеку
        library.AddBook(new Book { Title = "Мастер и Маргарита", Author = "Булгаков", Year = 1956 });
        library.AddBook(new Book { Title = "Властелин колец", Author = "Толкин", Year = 1976 });
        library.AddBook(new Book { Title = "рпавыпав", Author = "вапролбд", Year = 2010 });

        // Поиск книги по автору
        List<Book> booksByAuthor = library.FindByAuthor("Булгаков");
        Console.WriteLine("Книги автора 'Булгаков':");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine(book);
        }

        // Сортировка по году издания
        library.SortByYear();

    
        library.DisplayAllBooks();
    }
}