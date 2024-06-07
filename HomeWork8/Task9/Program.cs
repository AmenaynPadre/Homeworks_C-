namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool isNum = int.TryParse(s[i], out int x);
                if (s[i].Length > 0 && !isNum)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
