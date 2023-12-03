using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
    public class QueueService
    {
        private Queue<Client> QueueClient = new Queue<Client>();

        // Добавление клиента в очередь
        public void AddClient(Client client)
        {
            QueueClient.Enqueue(client);
            Console.WriteLine($"Клиент {client.Id} добавлен очередь");
        }

        // Обслуживание клиентов в порядке очереди
        public void ServeClients()
        {
            while (QueueClient.Count > 0)
            {
                Client currentClient = QueueClient.Dequeue();
                Console.WriteLine($"Обслужен клиент {currentClient.Name} с ID {currentClient.Id}.");
                DisplayQueueStatus(); //пункт 4 - показывать текущее состояние очереди
            }

            Console.WriteLine("Очередь закончилась.");
        }

        public void DisplayQueueStatus()
        {
            int totalClients = QueueClient.Count;

            if (totalClients > 0)
            {
                Console.WriteLine($"Текущее состояние очереди: {totalClients} человек(а)");
            }
        }
    }
}
