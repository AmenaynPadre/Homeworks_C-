namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 2 2 1 1 1
            //int x = new Random().Next(0,2);
            //int bigFloat = 1;
            //int medFloat = 2;
            //int smallFloat = 3;
            //char emptyBox = ' ';
            //bool horizontal;

            //Console.WriteLine(new string('-', 15));
            //for (int i = 0; i < 10; i++)
            //{
            //    horizontal = x == 0 ? true : false;
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine(new string('-', 15));

            int rows = 10;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            int bigFloat = 1;
            int medFloat = 2;
            int smallFloat = 3;

            for (int i = 0; i < smallFloat; i++)
            {
                int x = new Random().Next(0, 10);
                //Console.WriteLine(x);
                board[x, x] = 'S';
            }

            for (int i = 0; i < medFloat; i++)
            {
                int x = new Random().Next(0, 10);
                bool horizontal = new Random().Next(0, 2) == 0 ? true : false;
                //Console.WriteLine(x + "M");
                //Console.WriteLine(horizontal);
                if (horizontal)
                {
                    if (x > 8)
                    {
                        board[x, x] = 'M';
                        board[x, x - 1] = 'M';
                    }
                    else
                    {
                        board[x, x] = 'M';
                        board[x, x + 1] = 'M';
                    }
                }
                else
                {
                    if (x > 8)
                    {
                        board[x, x] = 'M';
                        board[x - 1, x] = 'M';
                    }
                    else
                    {
                        board[x, x] = 'M';
                        board[x + 1, x] = 'M';
                    }
                }
            }

            for (int i = 0; i < bigFloat; i++)
            {
                int x = new Random().Next(0, 11);
                bool horizontal = new Random().Next(0, 2) == 0 ? true : false;
                if (horizontal)
                {
                    if (x > 7)
                    {
                        board[x, x] = 'B';
                        board[x, x - 1] = 'B';
                        board[x, x - 2] = 'B';
                    }
                    else
                    {
                        board[x, x] = 'B';
                        board[x, x + 1] = 'B';
                        board[x, x + 2] = 'B';
                    }
                }
                else
                {
                    if (x > 7)
                    {
                        board[x, x] = 'B';
                        board[x - 1, x] = 'B';
                        board[x - 2, x] = 'B';
                    }
                    else
                    {
                        board[x, x] = 'B';
                        board[x + 1, x] = 'B';
                        board[x + 2, x] = 'B';
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
