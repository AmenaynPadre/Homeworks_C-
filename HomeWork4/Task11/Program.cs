namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "TTT";
            string str2 = "TTT";
            string str3 = new string(new char[] { 'T', 'T', 'T' });

            bool x = ReferenceEquals(str1, str2);
            bool y = ReferenceEquals(str1, str3);

            Console.WriteLine($"ReferenceEquals(str1, str2): {x}");
            Console.WriteLine($"ReferenceEquals(str1, str3): {y}");
        }
    }
}
