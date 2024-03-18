namespace LR_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, f, m;
            m = 10;
            for (x = 0; x <= Math.PI / 2; x += Math.PI / (2 * m))
            {
                f = x - Math.Sin(x);
                Console.WriteLine($"x = {x}, f(x) = {f}"); 
            }
        }
    }
}
