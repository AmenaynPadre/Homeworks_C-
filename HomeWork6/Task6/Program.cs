namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "start"; 

            switch (command)
            {
                case "start":
                    Console.WriteLine("App is runnig");
                    break;
                case "stop":
                    Console.WriteLine("App is stopped");
                    break;
                case "pause":
                    Console.WriteLine("App is pause");
                    break;
                case "resume":
                    Console.WriteLine("Resume");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
