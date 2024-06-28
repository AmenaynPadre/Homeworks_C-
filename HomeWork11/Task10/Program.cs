namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string, int, bool) person1 = GetPersonInfo("Narek", 21);

            Console.WriteLine(person1);
        }

        static (string, int, bool) GetPersonInfo(string n, int a)
        {
            bool isAdult = a >= 18 ? true : false;
            return (n, a, isAdult);
        }
    }
}
