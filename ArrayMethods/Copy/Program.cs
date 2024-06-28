namespace Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = {1,2,3,4 };
            int[] y = Copy(x);

            Console.WriteLine(y);
        }

        static int[] Copy(int[] source)
        {
            int[] copy = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                copy[i] = source[i];
            }

            return copy;
        }
    }
}
