using System;
namespace Module4_Practice
{
    public class Student
    {

        public string Name { get; set; }
        public string GroupNumber { get; set; }
        public int[] Grades { get; set; }

        public double CalculateAverageGrade()
        {
            return Grades.Average();
        }

        public void PrintStudentsWithGoodGrades()
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
                        break; // Если найдена оценка отличная от 4 и 5, можно завершить цикл.
                    }
                }

                if (hasOnlyGoodGrades)
                {
                    Console.WriteLine($"Фамилия: {student.Name}, Группа: {student.GroupNumber}");
                }
            }
        }
    }
}
