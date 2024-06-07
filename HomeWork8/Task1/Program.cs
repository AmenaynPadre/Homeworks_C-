namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(num[i]);
            }

            int max = num[0];

            //Console.WriteLine(num);

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
