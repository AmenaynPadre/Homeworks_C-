namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n;
            bool isInt = int.TryParse(Console.ReadLine(), out n);

            if (isInt)
            {
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
