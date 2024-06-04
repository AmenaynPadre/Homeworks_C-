namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            if (a > b)
            {
                if (a > c)
                {
                    if(a > d)
                    {
                        Console.WriteLine("Max: " + a);
                    }
                }
            }
            else if (b > c)
            {
                if (b > a)
                {
                    if (b > d)
                    {
                        Console.WriteLine("Max: " + b);
                    }
                }
            }
            else if (c > a)
            {
                if (c > b)
                {
                    if(c > d)
                    {
                        Console.WriteLine("Max: " + c);
                    }
                }
            }
            else if (d > a)
            {
                if (d > b)
                {
                    if (d > c)
                    {
                        Console.WriteLine("Max: " + d);
                    }
                }
            }
        }
    }
}
