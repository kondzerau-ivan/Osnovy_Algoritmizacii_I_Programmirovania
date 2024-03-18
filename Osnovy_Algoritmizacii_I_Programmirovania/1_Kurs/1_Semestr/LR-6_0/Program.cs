namespace LR_6_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				double a, b, Xn, Xk, dX, x, f;
				Console.WriteLine("Введите a:");
				a = double.Parse(Console.ReadLine());
				Console.WriteLine("Введите b:");
				b = double.Parse(Console.ReadLine());
				Console.WriteLine("Введите Xn:");
				Xn = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите Xk:");
				Xk = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите dX:");
				dX = double.Parse(Console.ReadLine());
				for (x = Xn; x <= Xk; x += dX)
				{
					if (x <= 0 && a == b)
					{
						f = Math.Sqrt(Math.Abs(a * x));
					} else if (x > 0 && x <= b || a != 0)
					{
						f = Math.Sin(b * x);
					} else f = 0;
					Console.WriteLine($"x = {x}, f(x) = {f}");
				}
            }
			catch (Exception e)
			{

				Console.WriteLine($"Ошибка: {e.Message}");
				Console.ReadKey();
			}
        }
    }
}
