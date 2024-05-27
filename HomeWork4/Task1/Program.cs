namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine(str.Length);
            string strUpperCase = str.ToUpper();
            Console.WriteLine(strUpperCase);
            string strLowerCase = str.ToLower();
            Console.WriteLine(strLowerCase);
            int i = strLowerCase.IndexOf("world");
            string x = str.Substring(i);
            Console.WriteLine(x);
        }
    }
}
