using System;
using System.IO.Compression;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Task_1*/
        Console.WriteLine("Введите путь к директории:");
        string path = Console.ReadLine();

        try
        {
            // Получение списка файлов и поддиректорий
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            // Вывод списка файлов
            Console.WriteLine("Файлы:");
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            // Вывод списка поддиректорий
            Console.WriteLine("Поддиректории:");
            foreach (string directory in directories)
            {
                Console.WriteLine(Path.GetFileName(directory));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        /*Task_2*/
        Console.WriteLine("\nВведите имя файла для создания:");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(path, fileName);

        File.Create(filePath).Close(); 
        Console.WriteLine($"Файл '{fileName}' создан.");

        /*Task_3*/
        Console.WriteLine("Введите имя файла для удаления:");
        string fileNameToDelete = Console.ReadLine();
        string filePathToDelete = Path.Combine(path, fileNameToDelete);

        if (File.Exists(filePathToDelete))
        {
            File.Delete(filePathToDelete); 
            Console.WriteLine($"Файл '{fileNameToDelete}' удален.");
        }
        else
        {
            Console.WriteLine($"Файл '{fileNameToDelete}' не найден.");
        }

        /*Task_4*/
        Console.WriteLine("Введите имя файла для копирования:");
        string sourceFileName = Console.ReadLine();
        string sourceFilePath = Path.Combine(path, sourceFileName);

        Console.WriteLine("Введите путь для сохранения копии файла:");
        string destination = Console.ReadLine();
        string destinationpath= Path.Combine(destination, sourceFileName);

        File.Copy(sourceFilePath, destinationpath); // Копирование файла
        Console.WriteLine($"Файл '{sourceFileName}' скопирован в '{destinationpath}'.");

        /*Task_5*/
        Console.WriteLine("Введите имя файла для записи:");
        string fileNameNew = Console.ReadLine();
        string filePathNew = Path.Combine(path, fileNameNew);

        Console.WriteLine("Введите текст для записи в файл:");
        string textToWrite = Console.ReadLine();

        File.WriteAllText(filePath, textToWrite);
        Console.WriteLine($"Текст записан в файл '{fileNameNew}'.");


        /*чтение*/

        Console.WriteLine($"Читаем раннее заполненный файл {fileNameNew}");
        string filePathToRead = Path.Combine(path, fileNameNew);

        if (File.Exists(filePathToRead))
        {
            string content = File.ReadAllText(filePathToRead);
            Console.WriteLine($"Содержимое файла '{fileNameNew}':\n{content}");
        }
        else
        {
            Console.WriteLine($"Файл '{fileNameNew}' не найден.");
        }
    }

   

}