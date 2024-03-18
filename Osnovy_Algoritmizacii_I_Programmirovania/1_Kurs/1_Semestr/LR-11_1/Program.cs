namespace LR_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            int[,] matrix;
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
            Console.WriteLine("Ваша матрица:");
            for (int i = 0; i < n; i++)
            {
                string bufferStr = "";
                for (int j = 0;j < m; j++)
                {
                    bufferStr += "| " + matrix[i, j] + " |";
                }
                Console.WriteLine(bufferStr);
            }
            // Ищем кол-во столбцов без нулей
            int colsCounter = 0;
            int notZeroBuffer = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] != 0)
                    {
                        notZeroBuffer++;
                    }
                }
                if (notZeroBuffer == n)
                {
                    colsCounter++;
                }
                notZeroBuffer = 0;
            }
            Console.WriteLine($"Кол-во столбцов не содержащих ни одного нулевого элемента: {colsCounter}");
        }
    }
}
