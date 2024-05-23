namespace Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string b = "■ ";
            string w = "O ";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(b);
                    }
                    else
                    {
                        Console.Write(w);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
