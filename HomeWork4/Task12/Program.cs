namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";

            // Используем метод Equals для сравнения строк
            bool x = str1.Equals(str2);
            bool y = str1.Equals(str3);

            // Выводим результаты на консоль
            Console.WriteLine($"str1.Equals(str2): {x}");
            Console.WriteLine($"str1.Equals(str3): {y}");
        }
    }
}
