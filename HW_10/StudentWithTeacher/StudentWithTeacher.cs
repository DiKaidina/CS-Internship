namespace StudentWithTeacher
{
    public class StudentWithTeacher : Student.Student
    {
        public Teacher.Teacher Advisor { get; set; }

        public StudentWithTeacher(string firstName, string lastName, int studentId, string major, Teacher.Teacher advisor)
            : base(firstName, lastName, studentId, major)
        {
            Advisor = advisor;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Advisor full name: {Advisor?.FirstName} {Advisor?.LastName}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Advisor full name: {Advisor?.FirstName} {Advisor?.LastName}";
        }
    }
}