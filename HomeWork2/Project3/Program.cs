namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = DateTime.Now.Year;
            Console.WriteLine("Enter your year of birth");
            string str = Console.ReadLine();
            int birthYear = Convert.ToInt32(str, 10);
            int age = d - birthYear;
            Console.WriteLine("Your age is" + " " + age);
        }
    }
}
