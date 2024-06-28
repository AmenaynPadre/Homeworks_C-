namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 3, 4, 4, 5, 6 };
            decimal average;
            CalculateAverageWithOut(ints, out average);

            Console.WriteLine(average);
        }

        static void CalculateAverageWithOut(int[] arr, out decimal x)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            x = sum / arr.Length;
        }
    }
}
