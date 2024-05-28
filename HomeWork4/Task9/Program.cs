namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "HELLO";
            string str3 = "hello";
            Console.WriteLine("CurrentCulture");
            Console.WriteLine(str1.Equals(str2,StringComparison.CurrentCulture));
            Console.WriteLine("CurrentCultureIgnoreCase");
            Console.WriteLine(str1.Equals(str2,StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("Ordinal");
            Console.WriteLine(str1.Equals(str2,StringComparison.Ordinal));
            Console.WriteLine("OrdinalIgnoreCase");
            Console.WriteLine(str1.Equals(str2,StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("InvariantCulture");
            Console.WriteLine(str1.Equals(str2,StringComparison.InvariantCulture));
            Console.WriteLine("InvariantCultureIgnoreCase");
            Console.WriteLine(str1.Equals(str2,StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
