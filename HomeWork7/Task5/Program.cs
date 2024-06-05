namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string lowerStr = str.ToLower();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (lowerStr[i] == 'a' || lowerStr[i] == 'e' || lowerStr[i] == 'i' || lowerStr[i] == 'o' || lowerStr[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
