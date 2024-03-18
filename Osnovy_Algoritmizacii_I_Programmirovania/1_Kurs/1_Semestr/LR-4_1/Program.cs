namespace LR_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявляем переменные
            double x, y, xRadian;

            // Просим пользователя ввести "х":
            Console.WriteLine("Введите значение переменной 'x':");

            // Считываем, конвертируем полученную строку в число и присваем полученное значение переменной
            x = Convert.ToDouble(Console.ReadLine());

            // Переводим градусы в радианы
            xRadian = x * Math.PI / 180;

            if (x <= 0)
            {
                y = Math.Sin(xRadian);
            }
            else if (0 < x && x < Math.PI / 4)
            {
                y = Math.Asin(xRadian);
            }
            else if (Math.PI / 2 < x && x <= 64)
            {
                y = Math.Log(xRadian, 4);
            }
            else
            {
                y = 1 / x;
            }

            // Выводим результат в консоль
            Console.WriteLine($"y = {y}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.ReadKey();
        }
    }
}
