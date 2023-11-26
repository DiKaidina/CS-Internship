using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice_9
{
    public class Flash : Storage
    {
        private double memory; // Объем памяти в гигабайтах
        private double speed = 15;
        private double loadedDataSize; // Новое поле для отслеживания размера загруженных данных
        public Flash(string name, string model, double memory, double speed) : base(name, model)
        {
            this.memory = memory;
            this.speed = speed;
        }

        //реализация абстрактных методов
        public override double GetMemory()
        {
            return memory;
        }

        public override void CopyData()
        {
            Console.WriteLine($"Copying data to the flash drive with USB 3.0 speed {speed} MB/s...");
        }

   
        // Новый метод для загрузки данных на флешку
        public void LoadData(double dataSize)
        {
            CopyData();
            loadedDataSize += dataSize;
            Console.WriteLine($"Data loaded: {dataSize} GB");
        }

        public override double GetFreeSpace()
        {
            
            double totalMemory = GetMemory();
            double freeSpace = totalMemory - loadedDataSize;
            return freeSpace > 0 ? freeSpace : 0;
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Flash Drive Information: {Name} {Model}, Capacity: {memory} GB, USB 3.0 Speed: {speed} MB/s");
        }

    }
}
