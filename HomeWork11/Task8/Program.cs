namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "cbA";

            bool b = IsAnagrams(str1, str2);

            Console.WriteLine(b);
        }

        static bool IsAnagrams(string x, string y)
        {
            if (x.Length != y.Length)
            {
                return false;
            }

            string reverseY = "";

            for (int i = y.Length - 1; i >= 0; i--)
            {
                reverseY += y[i];
            }

            return String.Compare(x, reverseY, StringComparison.OrdinalIgnoreCase) == 0 ? true : false;
        }
    }
}
