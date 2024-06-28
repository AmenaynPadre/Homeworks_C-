namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum;
            int[] ints = { 1, 2, 3, 4, 5, 6, 7 };
            FindMaximumWithOut(ints, out maximum);

            Console.WriteLine(maximum);
        }

        static void FindMaximumWithOut(int[] arr, out int x)
        {
            x = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(x < arr[i])
                {
                    x = arr[i];
                }
            }
        }
    }
}
