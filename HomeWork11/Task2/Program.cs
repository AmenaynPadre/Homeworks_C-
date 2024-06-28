namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = 'A';
            char char2 = 'Z';

            SwapCharactersWithRef(ref char1, ref char2);

            Console.WriteLine(char1);
            Console.WriteLine(char2);
        }

        static void SwapCharactersWithRef(ref char x, ref char y)
        {
            char temp = x;
            x = y;
            y = temp;
        }
    }
}
