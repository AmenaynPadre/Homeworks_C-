namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;

            if (age < 12)
            {
                Console.WriteLine("Child");
            }
            else if (age < 18)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 18 && age < 30)
            {
                Console.WriteLine("Adult");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
