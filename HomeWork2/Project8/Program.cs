namespace Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(493, 500);

            for (int i = 0; i < 10; i++)
            {
                Console.Beep(5000, 100);
            }
        }
    }
}
