namespace Teacher
{
    public class Teacher : Person.Person
    {
        public Teacher(string firstName, string lastName, string subject)
            : base(firstName, lastName)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Subject: {Subject}");
        }

        public override string ToString()
        {
            return base.ToString() + $", Subject: {Subject}";
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Teacher otherTeacher = (Teacher)obj;
            return Subject == otherTeacher.Subject;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Subject);
        }
    }
}