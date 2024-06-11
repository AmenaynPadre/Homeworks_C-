namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(str, out num);
            int sum = 0;

            if (isNum)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    int d = str[i] - '0';
                    sum += (int)Math.Pow(d, str.Length);
                }
            }
            else
            {
                Console.WriteLine("Write Number");
            }

            if (sum == num)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
