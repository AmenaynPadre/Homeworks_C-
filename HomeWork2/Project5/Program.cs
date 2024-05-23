namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter background color \n1.Red \n2.Blue \n3.Green");
            string bg = Console.ReadLine();
            if (bg == "1")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (bg == "2")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (bg == "3")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("I cant help you");
            }
            Console.Write("Enter text color color \n1.White \n2.Magenta \n3.Yellow");
            string tc = Console.ReadLine();
            if (tc == "1")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (tc == "2")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (tc == "3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.WriteLine("I cant help you");
            }
        }
    }
}

