namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Please, write your first number.";
            Console.Write(text);
            double firsInput = double.Parse(Console.ReadLine());

            string text2 = "Please, write your second number.";
            Console.Write(text2);
            double secondInput = double.Parse(Console.ReadLine());

            string text3 = "Choose one of these arithmetic actions: + - * / .";
            Console.Write(text3);
            char result;
            string y = Console.ReadLine();
            bool isChar = char.TryParse(y, out result);
            

            if (isChar)
            {
                if (result.Equals('+'))
                {
                    double result3 = firsInput + secondInput;
                    Console.Write($"Your calculated number is {result3}");
                }
                if (result.Equals('-'))
                {
                    double result4 = firsInput - secondInput;
                    Console.Write($"Your calculated number is {result4}");
                }
                if (result.Equals('/'))
                {
                    double result5 = firsInput / secondInput;
                    Console.Write($"Your calculated number is {result5}.");
                }

                if (result.Equals('*'))
                {
                    double result6 = firsInput * secondInput;
                    Console.Write($"Your calculated number is {result6}.");

                }
            }
            else
            {
                Console.WriteLine("InValid operator");
                Console.WriteLine(y);
                char x = char.Parse(y.Substring(0, 1));
                if (x.Equals('+'))
                {
                    double result3 = firsInput + secondInput;
                    Console.Write($"Your calculated number is {result3}");
                }
                if (x.Equals('-'))
                {
                    double result4 = firsInput - secondInput;
                    Console.Write($"Your calculated number is {result4}");
                }
                if (x.Equals('/'))
                {
                    double result5 = firsInput / secondInput;
                    Console.Write($"Your calculated number is {result5}.");
                }

                if (x.Equals('*'))
                {
                    double result6 = firsInput * secondInput;
                    Console.Write($"Your calculated number is {result6}.");

                }
                //char x = char.Parse(result.ToString().Substring(0));
                //Console.WriteLine(result.ToString());
                //Console.WriteLine($"x {x}");
            }
        }
    }
}
