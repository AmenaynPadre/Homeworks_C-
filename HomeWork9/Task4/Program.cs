namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 15, 12, 10 };
            int[] ints2 = new int[3];

            Array.Copy(ints, ints2, ints.Length);

            Console.WriteLine(ints2);

            for (int i = 0; i < ints2.Length; i++)
            {
                Console.WriteLine(ints2[i]);
            }
        }
    }
}
