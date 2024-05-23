namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = DateTime.Now.Year;
            Console.WriteLine("Enter your age");
            string str = Console.ReadLine();
            int age = Convert.ToInt32(str);
            int birthYear = d - age;
            Console.WriteLine("Your birth year" + " " + birthYear);
        }
    }
}
