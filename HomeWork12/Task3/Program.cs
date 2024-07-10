namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Narek", "Simonyan", 21);
            Person p2 = new Person("Poxos", "Poxosyan", 25);
            Person p3 = new Person("Petros", "Petrosyan", 35);

            Person[] people = {p1, p2, p3};
            var x = Person.CalculateAverageAge(people);
            Console.WriteLine($"{x.Age}");
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

            static public Person CalculateAverageAge(Person[] arr)
            {
                var result = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if(result.Age < arr[i].Age)
                    {
                        result = arr[i];
                    }
                }

                return result;
            }
        }
    }
}
