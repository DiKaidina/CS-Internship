//Обработка исключений
using System.Net.Http;

internal class Program
{

    static void Request(string url)
    {
        HttpClient httpClient = new HttpClient();
        try
        {
            HttpResponseMessage request = httpClient.GetAsync(url).Result;
            request.EnsureSuccessStatusCode(); // Проверка на успешный статус код
            string content = request.Content.ReadAsStringAsync().Result;//Асинхронное чтение(чтобы не блокровать поток), но result наоборот блокирует
            Console.WriteLine($"Содержимое страницы:\n{content}");
        }
        catch (HttpRequestException e)
        {
            
            Console.WriteLine($"Произошла ошибка при запросе к ресурсу {url}: {e.Message}");
        }
        catch (Exception e)
        {
            // Обработка других исключений
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        finally
        {
            httpClient.Dispose(); 
        }
    }

    static void IndexOutRange()
    {
        int[] arr = { 1, 2, 3 };
        int index = 4;
        try
        {
            int value = arr[index]; // Пытаемся получить элемент
            Console.WriteLine($"Элемент {index}: {value}");
        }
        catch (IndexOutOfRangeException e)
        {
            
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (Exception e)
        {
            
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Обработка массива завершена");
        }

    }


    static void Method1()
    {
        Console.WriteLine("Вызвали метод 1");

        throw new IndexOutOfRangeException("Ошибка в первом методе"); //выплюнули ошибку для обработки во втором методе
    }

    static void Method2()
    {
        Console.WriteLine("Вызвали метод 2");
        try
        {
            Method1();
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Метод 2 ошибка: {ex.Message}");
           
        }
        
    }
    private static void Main(string[] args)
    {
        //Task_1. Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка.
        //Программа должна завершиться без ошибок

        /*string url = "http://dianakaidina.com"; 
        Request(url);*/


        //Task_2 
        /*Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
         * После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива*/

        //IndexOutRange();

        //Task_3
        /*Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
         * В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод*/

        //Method2();

    }
}