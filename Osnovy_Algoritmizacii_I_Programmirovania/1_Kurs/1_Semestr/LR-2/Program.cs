namespace LR_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявляем переменные
            double gradus, radian, z1, z2;

            // Просим пользователя ввести угол в градусах
            Console.WriteLine("Введите угол в градусах:");

            // Считываем, конвертируем полученную строку в число и присваем полученное значение переменной
            gradus = Convert.ToDouble(Console.ReadLine());

            // Переводим градусы в радианы
            radian = gradus * Math.PI / 180;

            // Рассчитываем значения z1 и z2
            z1 = (Math.Sin(4 * radian) / (1 + Math.Cos(4 * radian))) * (Math.Cos(2 * radian) / (1 + Math.Cos(2 * radian)));
            z2 = 1 / Math.Tan((3.0 / 2) * Math.PI - radian);

            // Выводим результат в консоль
            Console.WriteLine($"z1 = {z1}, z2 = {z2}");

            // Ожидаем нажатия клавиши для закрытия консоли
            Console.ReadKey();
        }
    }
}
