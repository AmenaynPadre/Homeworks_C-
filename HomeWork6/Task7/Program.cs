namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20; 
            bool hasLicense = true;

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Can drive");
                }
                else
                {
                    Console.WriteLine("No license");
                }
            }
            else
            {
                Console.WriteLine("< 18");
            }
        }
    }
}
