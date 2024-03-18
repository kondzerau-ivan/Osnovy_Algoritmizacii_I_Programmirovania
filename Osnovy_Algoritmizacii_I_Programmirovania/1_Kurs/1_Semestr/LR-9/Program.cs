using System.Linq.Expressions;

namespace LR_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, maxElemIndex, maxElem;
            maxElemIndex = 0;
            maxElem = 0;
            Console.WriteLine("Введите размерность массива N:");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // Заполняем массив на N-элементов
            Console.WriteLine("--- Заполняем массив на N-элементов ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите следующий элемент массива:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ваш массив: " + string.Join(", ", arr));
            // Поиск индекса максимального по модулю элемента
            Console.WriteLine("--- Поиск индекса максимального по модулю элемента ---");
            int sum, firstPositiveElemIndex;
            sum = 0;
            firstPositiveElemIndex = n;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(arr[maxElemIndex]))
                {
                    maxElemIndex = i;
                    //maxElem = Math.Abs(arr[i]);
                }
            }
            Console.WriteLine($"Индекс максимального по модулю элемента массива: {maxElemIndex}");
            // Сумма элементов после первого положительного
            Console.WriteLine("--- Поиск суммы элементов после первого положительного ---");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    firstPositiveElemIndex = i + 1;
                    break;
                }
            }
            while (firstPositiveElemIndex < n)
            {
                sum += arr[firstPositiveElemIndex];
                firstPositiveElemIndex++;
            };
            Console.WriteLine($"Сумма элементов массива, расположенных после первого положительного: {sum}");
            //Преобразовать массив: сначала элементы внутри интервала [a, b], после все остальные
            Console.WriteLine("--- Преобразовать массив: сначала элементы внутри интервала [a, b], после все остальные ---");
            Console.WriteLine("Введите a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= a && arr[i] <= b)
                {
                    if (i != j)
                    {
                        int buffer = arr[j];
                        arr[j] = arr[i];
                        arr[i] = buffer;
                    }
                    j++;
                }
            }
            Console.WriteLine("Обновлённый массив: " + string.Join(", ", arr));
        }
    }
}
