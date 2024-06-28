namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            
            Console.WriteLine(IndexOf(ints, 7));
        }

        static int IndexOf(int[] source, int num)
        {
            int index = -1;

            for (int j = 0; j < source.Length; j++)
            {
                if (source[j] == num)
                {
                    index = j;
                }
            }

            return index;
        }
    }
}
