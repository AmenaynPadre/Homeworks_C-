using System.Xml;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(1, 100);
            int count = 0;
            Console.WriteLine(random);

            while (count < 7)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == random)
                {
                    Console.WriteLine("Win");
                    break;
                }
                else
                {
                    if (num - random < 0)
                    {
                        Console.WriteLine("barcr");
                    }
                    if (num - random > 0)
                    {
                        Console.WriteLine("cacr");
                    }
                    
                }
            }
            count++;
        }

    }
}

