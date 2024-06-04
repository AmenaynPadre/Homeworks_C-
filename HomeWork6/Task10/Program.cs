namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine("Max: " + a);
                }
            }
            else if (b >= c)
            {
                if (b >= a)
                {
                    Console.WriteLine("Max: " + b);
                }
            }
            else if (c >= a)
            {
                if (c >= b)
                {
                    Console.WriteLine("Max: " + c);
                }
            }
        }
    }
}
