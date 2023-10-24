using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    public class ArrayClass
    {
        private int[] data;

        public ArrayClass(int size)
        {
            data = new int[size];
        }

        public int Length
        {
            get { return data.Length; }
        }

        public static ArrayClass operator *(ArrayClass array1, ArrayClass array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("У массивов должен быть один размер");
            }

            ArrayClass result = new ArrayClass(array1.Length);

            for (int i = 0; i < array1.Length; i++)
            {
                result.data[i] = array1.data[i] * array2.data[i];
            }

            return result;
        }

        public static bool operator ==(ArrayClass array1, ArrayClass array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.data[i] != array2.data[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(ArrayClass array1, ArrayClass array2)
        {
            return !(array1 == array2);
        }

        public static bool operator <=(ArrayClass array1, ArrayClass array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одного размера");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.data[i] > array2.data[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator >=(ArrayClass array1, ArrayClass array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одного размера");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.data[i] < array2.data[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static ArrayClass operator +(ArrayClass array1, ArrayClass array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одного размера");
            }

            ArrayClass result = new ArrayClass(array1.Length);

            for (int i = 0; i < array1.Length; i++)
            {
                result.data[i] = array1.data[i] + array2.data[i];
            }

            return result;
        }

        public static ArrayClass operator -(ArrayClass array1, ArrayClass array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Массивы должны быть одного размера");
            }

            ArrayClass result = new ArrayClass(array1.Length);

            for (int i = 0; i < array1.Length; i++)
            {
                result.data[i] = array1.data[i] - array2.data[i];
            }

            return result;
        }
    }
}
