namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "abcd";

            ReverseString(ref x);

            Console.WriteLine(x);
        }

        static void ReverseString(ref string str)
        {
            string result = "";
            
            for (int i = str.Length - 1; i >= 0 ; i--)
            {
                result += str[i];
            }

            str = result;
        }
    }
}
