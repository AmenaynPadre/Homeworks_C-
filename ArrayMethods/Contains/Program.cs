namespace Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static bool Contains(int[] source, int target)
        {
            bool result = false;

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == target)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
