namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "20";
            int x = int.Parse(str);
            Console.WriteLine(x);

            string str1 = "10a0";
            int num;
            Console.WriteLine(int.TryParse(str1,out num));
            Console.WriteLine(num);


        }
    }
}
