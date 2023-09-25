using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    internal class Student
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public int[] Grades { get; set; }

        public double AverageGrade()
        {
            return Grades.Average();
        }

        public void WithGoodGrades()
        {
            Console.WriteLine("Студенты с оценками 4 и 5:");
            foreach (var student in Program.Students)
            {
                bool hasOnlyGoodGrades = true;

                foreach (var grade in student.Grades)
                {
                    if (grade != 4 && grade != 5)
                    {
                        hasOnlyGoodGrades = false;
                        break;
                    }
                }

                if (hasOnlyGoodGrades)
                {
                    Console.WriteLine($"Фамилия: {student.Name}, Группа: {student.Group}");
                }
            }
        }
    }
}
