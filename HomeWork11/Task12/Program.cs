namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "adadaf asfasfas asfasfasf asfasfas adadaf";
            var y = SplitStringIntoWords(x);

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }
        }

        static string[] SplitStringIntoWords(string str)
        {
            string[] result = { };
            string[] splitedStr = str.Split(' ');

            //for (int i = 0; i < splitedStr.Length; i++)
            //{
            //    Console.WriteLine(splitedStr[i]);
            //}

            for (int i = 0; i < splitedStr.Length; i++)
            {
                if (!result.Contains(splitedStr[i], StringComparer.OrdinalIgnoreCase))
                {
                    result = result.Append(splitedStr[i]).ToArray();
                }
            }

            return result;
        }
    }
}
