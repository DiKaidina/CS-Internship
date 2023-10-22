using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    public class SquaredArray
    {
        private int[] array;

        public SquaredArray(int size)
        {
            array = new int[size];
        }

        //индексатор
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value * value; }
        }
    }
}
