namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            double y = 20.2d;
            //x = y; // error
            y = x;
            Console.WriteLine(y);
        }
    }
}
