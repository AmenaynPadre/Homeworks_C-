namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] ints = { 2, 5, 8 };

            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            Console.WriteLine(sum);
        }
    }
}
