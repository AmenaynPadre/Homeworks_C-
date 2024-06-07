namespace Task7
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
                    int x = str[i] - '0';

                    if(x % 2 == 0)
                    {
                        sum += x;
                    }
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Write Number");
            }
        }
    }
}
