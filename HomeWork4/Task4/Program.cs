namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s";
            int i = str.ToLower().IndexOf("simply");
            if (i > 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine(i);
        }
    }
}
