using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice_9
{
    public abstract class Storage
    {
        protected string name;
        protected string model;

        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public abstract double GetMemory();

        public abstract void CopyData();

        public abstract double GetFreeSpace();

        public abstract void GetDeviceInfo();
    }
}
