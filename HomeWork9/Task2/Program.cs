namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 5, 7 };

            for (int i = ints.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}
