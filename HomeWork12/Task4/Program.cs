namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1.2, 5.3);

            Console.WriteLine($"X - {p.X}, Y - {p.Y}");
        }
    }

    struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
