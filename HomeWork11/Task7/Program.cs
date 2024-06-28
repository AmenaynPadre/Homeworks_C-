namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int product = 0;
            int x = 10;
            int y = 20;

            GetSumAndProduct(x, y, out sum, out product);

            Console.WriteLine(sum);
            Console.WriteLine(product);
        }

        static void GetSumAndProduct(int n1, int n2, out int s, out int p)
        {
            s = n1 + n2;
            p = n1 * n2;
        }
    }
}
