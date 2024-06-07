namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlay = true;

            while (isPlay)
            {
                int x = new Random().Next(1, 4);
                Console.WriteLine("1.Rock\n2.Paper\n3.Scissors");
                int n = int.Parse(Console.ReadLine());
                string variant = "";

                if(x == 1)
                {
                    variant = "Rock";
                }
                else if (x == 2)
                {
                    variant = "Paper";
                }
                else if (x == 3)
                {
                    variant = "Scissors";
                }

                if ((x == 1 && n == 1) || (x == 3 && n == 3) || (x == 3 && n == 3))
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine(variant);
                }
                else
                {
                    if (x == 1 && n == 2)
                    {
                        Console.WriteLine("You Win");
                        Console.WriteLine(variant);
                    }
                    else if (x == 2 && n == 3)
                    {
                        Console.WriteLine("You Win");
                        Console.WriteLine(variant);
                    }
                    else if (x == 3 && n == 1)
                    {
                        Console.WriteLine("You Win");
                        Console.WriteLine(variant);
                    }
                    else if (x == 2 && n == 1)
                    {
                        Console.WriteLine("You Lose");
                        Console.WriteLine(variant);
                    }
                    else if (x == 3 && n == 2)
                    {
                        Console.WriteLine("You Lose");
                        Console.WriteLine(variant);
                    }
                    else if (x == 1 && n == 3)
                    {
                        Console.WriteLine("You Lose");
                        Console.WriteLine(variant);
                    }
                }
                Console.WriteLine("Want to play again : YES or NO");
                string a = Console.ReadLine();
                if (a.ToLower() == "yes")
                {
                    isPlay = true;
                }
                else
                {
                    isPlay = false;
                }
            }
        }
    }
}

