namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            int sum;
            decimal average;
            int maximum;

            CalculateStatistics(ints, out sum, out average, out maximum);

            Console.WriteLine(sum);
            Console.WriteLine(average);
            Console.WriteLine(maximum);

        }

        static void CalculateStatistics(int[] arr, out int sum, out decimal average, out int maximum)
        {
            sum = CalculateSum(arr);
            average = CalculateAverage(arr);
            maximum = arr.Max();
        }

        static int CalculateSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static decimal CalculateAverage(int[] arr)
        {
            decimal average = CalculateSum(arr) / arr.Length;

            return average;
        }

        //static int GetMaximum(int[] arr)
        //{
        //    return arr.Max();
        //}
    }
}
