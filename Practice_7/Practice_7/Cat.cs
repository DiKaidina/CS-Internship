using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Array { get; }

        public Cat(int[] array, string name, int age)
        {
            Array = array;
            Name = name;
            Age = age;
        }





        public static bool operator <(Cat cat1, Cat cat2)
        {
            int sum1 = cat1.Array.Sum();
            int sum2 = cat2.Array.Sum();
            return sum1 < sum2;
        }

        public static bool operator >(Cat cat1, Cat cat2)
        {
            int sum1 = cat1.Array.Sum();
            int sum2 = cat2.Array.Sum();
            return sum1 > sum2;
        }

        //перегрузка ==
        public static bool operator ==(Cat cat1, Cat cat2)
        {
            if (ReferenceEquals(cat1, null) && ReferenceEquals(cat2, null))
                return true;
            if (ReferenceEquals(cat1, null) || ReferenceEquals(cat2, null))
                return false;

            return cat1.Equals(cat2);
        }

        //перегрузка !=
        public static bool operator !=(Cat cat1, Cat cat2)
        {
            return !(cat1 == cat2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Cat anotherCat)
            {
                return Name == anotherCat.Name && Age == anotherCat.Age;
            }
            return false;
        }
    }
}
