namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[50];

            for (int i = 0; i < 50; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(num[i]);
            }

            decimal sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum = (sum + num[i]) / num.Length;
            }

            //Console.WriteLine(num.Length);
            Console.WriteLine(sum);
        }
    }
}
