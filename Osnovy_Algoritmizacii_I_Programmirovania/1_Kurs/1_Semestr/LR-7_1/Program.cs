namespace LR_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, sum, count;
            sum = 0;
            count = 0;
            Console.WriteLine("Введите сумму М:");
            m = int.Parse(Console.ReadLine());
            while (sum < m)
            {
                Console.WriteLine("Введите число:");
                sum += int.Parse(Console.ReadLine());
                count++;
            }

            Console.WriteLine($"Сумма: {sum}, кол-во чисел: {count}");
        }
    }
}
