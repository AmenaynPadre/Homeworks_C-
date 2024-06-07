namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char ch = char.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
