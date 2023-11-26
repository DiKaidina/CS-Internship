namespace Person
{
    public class Person 
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Person: {FirstName} {LastName}");
        }

        public override string ToString()
        {
            return $"Person: {FirstName} {LastName}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person otherPerson = (Person)obj;
            return FirstName == otherPerson.FirstName && LastName == otherPerson.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}