// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите значение b1: ");
    double num1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k1: ");
    double num2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b2: ");
    double num3 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k2: ");
    double num4 = int.Parse(Console.ReadLine()!);
    Intersection(num2, num1, num4, num3);
}

void Intersection(double k1, double b1, double k2, double b2)
{
    double x = -(b2 - b1) / (k2 - k1);
    double y = (k1 * x) + b1;
    PrintInt(x, y, k1, k2);
}

void PrintInt(double a, double b, double x1, double x2)
{
    if (x1 == x2)
    {
        Console.WriteLine("Эти прямые параллельны");
    }
    else
    {
        if (x1 * x2 == -1)
        {
            Console.WriteLine("Эти прямые перпендикулярны ");
        }
        Console.WriteLine($" --> ({a}; {b})");
    }
}

Main();