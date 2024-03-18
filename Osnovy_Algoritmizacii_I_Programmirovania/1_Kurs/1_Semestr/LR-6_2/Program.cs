namespace LR_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double s;
            s = 2;
            Console.WriteLine("Введите n:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++) 
            {
                s = 2 + Math.Sqrt(s);
            }
            Console.WriteLine($"Результат: {s}");
        }
    }
}
