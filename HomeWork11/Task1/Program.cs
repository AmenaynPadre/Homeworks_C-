namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double min;
            double[] x = { 1, 2, 3, 4, 7, -2 };
            FindMinimumWithOut(x, out min);

            Console.WriteLine(min);
        }

        static void FindMinimumWithOut(double[] arr, out double result)
        {
            result = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
            }
        }
    }
}
