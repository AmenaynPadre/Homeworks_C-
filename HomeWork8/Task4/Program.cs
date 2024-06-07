namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reversedStr = "";
            bool isPalindrome = false;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];

                if (str == reversedStr)
                {
                    isPalindrome = true;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("String is palindrome");
            }

        }
    }
}
