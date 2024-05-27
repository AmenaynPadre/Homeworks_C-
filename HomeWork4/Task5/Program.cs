namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "apple,banana,orange,C#,Java,JavaScript,Pyton";
            string[] arr = str.Split(',');
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            }
        }
    }
}
