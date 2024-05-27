namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "I love programming in Java";
            int i = str.IndexOf("Java");
            if (i > 0)
            {
                str = str.Replace("Java", "C#");
            }
            Console.WriteLine(i);
            Console.WriteLine(str);
        }
    }
}
