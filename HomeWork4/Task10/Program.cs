namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "HELLO";
            int hash1 = str1.GetHashCode();
            int hash2 = str2.GetHashCode();
            int hash3 = str3.GetHashCode();
            Console.WriteLine(hash1);
            Console.WriteLine(hash2);
            Console.WriteLine(hash3);


            if (hash1 == hash2)
            {
                Console.WriteLine("hash1 == hash2");
            }
            else
            {
                Console.WriteLine("hash1 != hash2");
            }

            if (hash1 == hash3)
            {
                Console.WriteLine("hash1 == hash3");
            }
            else
            {
                Console.WriteLine("hash1 != hash3");
            }
        }
    }
}
