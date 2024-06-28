namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather x = Weather.Cloudy;

            switch (x)
            {
                case Weather.Sunny:
                    Console.WriteLine("Sunny weather");
                    break;
                case Weather.Cloudy:
                    Console.WriteLine("Cloudy waether");
                    break;
                case Weather.Rainy:
                    Console.WriteLine("Rainy weather");
                    break;
            }
        }

        enum Weather
        {
            Sunny,
            Cloudy,
            Rainy
        }
    }
}
