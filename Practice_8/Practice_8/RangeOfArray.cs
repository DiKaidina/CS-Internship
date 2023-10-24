using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    public class RangeOfArray
    {
        private int a; 
        private int b; 
        private int[] array;    

        public RangeOfArray(int lowerBound, int upperBound)
        {
            this.a = lowerBound;
            this.b = upperBound;
            int size = upperBound - lowerBound + 1;
            array = new int[size];
        }

        //индексатор
        public int this[int index]
        {
            get
            {
                if (IsValidIndex(index))
                {
                    int adjustedIndex = index - a;
                    return array[adjustedIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
            set
            {
                if (IsValidIndex(index))
                {
                    int adjustedIndex = index - a;
                    array[adjustedIndex] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                }
            }
        }

        private bool IsValidIndex(int index)
        {
            return index >= a && index <= b;
        }
    }
}
