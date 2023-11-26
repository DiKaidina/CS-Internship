using System;
using Person;


namespace Student
{
    public class Student : Person.Person
    {

        public int studentId { get; set; }
        public string Faculty { get; set; }

        public Student(string firstName, string lastName, int studentId, string Faculty): base(firstName, lastName)
        {
            this.studentId = studentId;
            this.Faculty = Faculty;
        }
        

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Student ID: {studentId}, Major: {Faculty}");
        }

        //расширяю функционал исходной функции - печатаю факультет и айди 
        public override string ToString()
        {
            return base.ToString() + $", Student ID: {studentId}, Faculty: {Faculty}";
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Student otherStudent = (Student)obj;
            return studentId == otherStudent.studentId &&   Faculty == otherStudent.Faculty;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), studentId, Faculty);
        }
    }
}