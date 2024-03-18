namespace LR_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n, m;
            int[,] matrix = {
                {0, 1, 1, 1 },
                {0, 2, 2, 2 },
                {0, 0, 0, 0 },
                {0, 4, 4, 4 }
            };
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            bool buffer = false;
            /*
            Console.WriteLine("Введите размер матрицы n x m:");
            Console.WriteLine("Введите n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m:");
            m = int.Parse(Console.ReadLine());
            matrix = new int[n, m];
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            */
            Console.WriteLine("Ваша матрица:");
            for (int i = 0; i < n; i++)
            {
                string bufferStr = "";
                for (int j = 0; j < m; j++)
                {
                    bufferStr += "| " + matrix[i, j] + " |";
                }
                Console.WriteLine(bufferStr);
            }

            // Удаляем строки с нулями

            for (int i = 0; i < n; i++)
            {
                buffer = true;
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        buffer = false;
                        break;
                    }
                }
                if (buffer)
                {
                    for (int k = i; k < (n - 1); k++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            matrix[k, j] = matrix[k + 1, j];
                        }
                    }
                }
            }

            // Удаляем столбцы с нулями
            
            for (int j = 0; j < m; j++)
            {
                buffer = true;
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] != 0)
                    {
                        buffer |= false;
                        break;
                    }
                }
                if (buffer)
                {
                    for (int k = j; k < (m - 1); k++)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            matrix[i, k] = matrix[i, k + 1];
                        }
                    }
                }
            }
            
            Console.WriteLine("Обновлённая матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string bufferStr = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bufferStr += "| " + matrix[i, j] + " |";
                }
                Console.WriteLine(bufferStr);
            }
        }
    }
}
