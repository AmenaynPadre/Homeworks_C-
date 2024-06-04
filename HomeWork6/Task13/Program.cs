namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            if (x > 8 && x <= 10)
            {
                Console.WriteLine("Excellent");
            }
            else if (x > 6 && x <= 8)
            {
                Console.WriteLine("Good");
            }
            else if (x > 4 && x <= 6)
            {
                Console.WriteLine("Average");
            }
            else if (x > 2)
            {
                Console.WriteLine("Poor");
            }
            else if (x < 2)
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
