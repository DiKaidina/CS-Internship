using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice_9
{
    public class DVD : Storage
    {
        private double speed;
        private string diskType;

        public DVD(string name, string model, double readWriteSpeed, string diskType) : base(name, model)
        {
            this.speed = readWriteSpeed;
            this.diskType = diskType;
        }

        public override double GetMemory()
        {
            // Возвращаем объем в зависимости от типа диска
            return (diskType == "односторонний") ? 4.7 : 9.0;
        }

        public override void CopyData()
        {
            Console.WriteLine($"Copying data to the DVD with read/write speed {speed}x...");
        }

        public override double GetFreeSpace()
        {
            // Предполагаем, что DVD пустой(нет смысла грузить на тот же диск, где что-то есть)
            return GetMemory();
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"DVD Information: {Name} {Model}, Read/Write Speed: {speed}x, Disk Type: {diskType}, Capacity: {GetMemory()} GB");
        }
    }
}
