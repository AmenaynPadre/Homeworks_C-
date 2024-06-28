namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            ModifyArrayWithRef(ref arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void ModifyArrayWithRef(ref int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = ints[i] * ints[i];
            }
        }
    }
}
