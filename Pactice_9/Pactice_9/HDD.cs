using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice_9
{
    public class HDD : Storage
    {
        private double speed;
        private int numPart;
        private double sizePart;

        public HDD(string name, string model, double speed, int numPart, double sizePart) : base(name, model)
        {
            this.speed = speed;
            this.numPart = numPart;
            this.sizePart = sizePart;
        }

        public override double GetMemory()
        {
            
            return numPart * sizePart;
        }

        public override void CopyData()
        {
            Console.WriteLine($"Copying data to the Removable HDD with USB 2.0 speed {speed} MB/s...");
        }

        public override double GetFreeSpace()
        {
            // Предполагаем, что HDD всегда свободен полностью перед копированием
            return GetMemory();
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Removable HDD Information: {Name} {Model}, USB 2.0 Speed: {speed} MB/s, Partition Count: {numPart}, Partition Size: {sizePart} GB, Capacity: {GetMemory()} GB");
        }
    }
}
