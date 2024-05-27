namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Narek";
            string surname = "Simonyan";
            string age = "21";
            string prof = "chka";

            Console.WriteLine($"{name} is {age} years old");
            Console.WriteLine(String.Format("{0} is {1} years old", name, age));
        }
    }
}
