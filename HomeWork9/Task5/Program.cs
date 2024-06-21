namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 5, 1, 1, 2, 3, 2, 3, 4 };
            int count = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
