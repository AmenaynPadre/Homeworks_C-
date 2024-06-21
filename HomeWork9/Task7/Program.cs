namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints1 = { 1, 2, 3 };
            int[] ints2 = { 1, 2, 3 };
            int[] ints3 = new int[ints1.Length + ints2.Length];

            for (int i = 0; i < ints1.Length; i++)
            {
                ints3[i] = ints1[i];
            }

            for (int i = 0; i < ints2.Length; i++)
            {
                ints3[ints1.Length + i] = ints2[i];
            }

            int temp = ints3[0];

            for (int i = 0; i < ints3.Length; i++)
            {
                
            }
        }
    }
}
