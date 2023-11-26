using Pactice_9;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаем массив ссылок на базовый класс Storage
        Storage[] devices = new Storage[]
        {
            new Flash("MyFlash", "ModelFlash",128 , 150),
            new DVD("MyDVD", "ModelDVD", 8, "односторонний"),
            new HDD("MyHDD", "ModelHDD", 256, 2, 250),
            
        };

        // 1. Расчет общего количества памяти всех устройств
        double totalMemory = 0;
        foreach (var device in devices)
        {
            totalMemory += device.GetMemory();
        }
        Console.WriteLine($"Общее количество памяти: {totalMemory} GB");

        // 2. Копирование информации на устройства
        foreach (var device in devices)
        {
            device.CopyData();
        }

        // 3. Расчет времени необходимого для копирования (перенос 565 Гб данных, размер файла 780 Мб)
        double totalDataSizeGB = 565;
        double fileSizeMB = 780;
        double totalDataSizeMB = totalDataSizeGB * 1024; 
        double copySpeedMBps = 50; 

        double copyingTimeSeconds = totalDataSizeMB / copySpeedMBps;
        Console.WriteLine($"Время, необходимое для копирования: {copyingTimeSeconds} секунд");

        // 4. Расчет необходимого количества носителей информации представленных типов для переноса информации
        int flashDriveCount = 0;
        int dvdCount = 0;
        int hddCount = 0;

        foreach (var device in devices)
        {
            if (device is Flash)
            {
                flashDriveCount++;
            }
            else if (device is DVD)
            {
                dvdCount++;
            }
            else if (device is HDD)
            {
                hddCount++;
            }
        }

        Console.WriteLine($"Количество Flash: {flashDriveCount}");
        Console.WriteLine($"Количество DVD-дисков: {dvdCount}");
        Console.WriteLine($"Количество съемных HDD: {hddCount}");
    }
}