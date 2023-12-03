using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_15
{
    class MyClass
    {
        private string name;
        private int age;
        private string occupation;

        public int Property { get; set; } /*Для задания 3*/
        private MyClass()
        {
            Console.WriteLine("Приватный конструктор");
        }

        public MyClass(string name, int age, string occupation)
        {
            Console.WriteLine("Публичный конструктор");
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        // Публичный метод
        public void PublicMethod()
        {
            Console.WriteLine($"Это пуличный метод выводит occupation : {occupation}, PRoperty : {Property}, name : {name}, age : {age}");
        }

        // Приватный метод
        private void PrivateMethod()
        {
            Console.WriteLine($"Это пуличный метод выводит name : {name}");
        }
    }
}
