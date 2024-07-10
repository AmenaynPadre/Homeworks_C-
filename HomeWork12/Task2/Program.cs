namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Narek","Simonyan",21);

            Console.WriteLine($"Person ` {p1.FirstName} {p1.LastName} {p1.Age}");
        }

        struct Person
        {
            public string FirstName;
            public string LastName;
            public int Age;

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }
    }
}
