using HW_13;

internal class Program
{
    private static void Main(string[] args)
    {
        QueueService queueService = new QueueService();

        while (true)
        {
            Console.WriteLine("1. Встать в очередь");
            Console.WriteLine("2. Обслужить следующего клиента");
            Console.WriteLine("3. Выйти из программы");
            Console.Write("Выберите действие (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите ваше имя: ");
                    string userName = Console.ReadLine();
                    Console.Write("Введите ваш ИИН(Id) numeric: ");
                    int userId;
                    while (!int.TryParse(Console.ReadLine(), out userId))
                    {
                        Console.WriteLine("Неверный формат ИИН. Попробуйте еще раз.");
                        Console.Write("Введите ваш ИИН: ");
                    }
                    queueService.AddClient(new Client(userId, userName, "Кредит"));
                    break;

                case "2":
                    queueService.ServeClients();
                    break;

                case "3":
                    Console.WriteLine("Программа завершена.");
                    return;

                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите действие от 1 до 3.");
                    break;
            }
        }
    }
}