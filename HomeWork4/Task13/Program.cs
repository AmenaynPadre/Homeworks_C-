namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";

            if (str1 == str2)
            {
                Console.WriteLine("str1 equals str2");
            }
            else
            {
                Console.WriteLine("str1 not equals str2");
            }

            if (str1 == str3)
            {
                Console.WriteLine("str1 equals str3");
            }
            else
            {
                Console.WriteLine("str1 not equals str3");
            }
        }
    }
}
