namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int naxordox = 0;
            int hajordox = 1;
            int sum = 0;

            // 1 1 2 3 5 8 13 21

            for (int i = 0; i <= n; i++)
            {
                sum = naxordox + hajordox;
                naxordox = hajordox;
                hajordox = sum;

                Console.WriteLine(sum);
            }
        }
    }
}
