namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int area, int perimetr) rectangleProperties = CalculateRectangleProperties(20, 30);
            Console.WriteLine(rectangleProperties.area);
            Console.WriteLine(rectangleProperties.perimetr);
        }

        static (int,int) CalculateRectangleProperties(int length, int width)
        {
            int area = length * width;
            int perimetr = (length * 2) + (width * 2);

            return (area, perimetr);
        }
    }
}
