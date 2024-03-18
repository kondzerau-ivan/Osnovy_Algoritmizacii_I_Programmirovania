namespace LR_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c , result;

            Console.WriteLine("Введите целое число 'a':");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число 'b':");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число 'c':");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                result = 3;
            }
            else if (a == c)
            { 
                result = 2;
            }
            else 
            {
                result = 1;
            }

            Console.WriteLine($"Порядковый номер числа отличного от остальных: {result}");
            Console.ReadKey();
        }
    }
}
