namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += int.Parse(x[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
