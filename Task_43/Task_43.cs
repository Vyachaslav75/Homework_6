double enterNumber(string msg, string errorMsg)
{
    double number;
    while (true)
    {
        Console.Write(msg);
        if (double.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}


void Cross()
{
    double k1 = enterNumber("Введите коэффициент k1: ", "Введите число");
    double b1 = enterNumber("Введите коэффициент b1: ", "Введите число");
    double k2 = enterNumber("Введите коэффициент k2: ", "Введите число");
    double b2 = enterNumber("Введите коэффициент b2: ", "Введите число");

    if (Math.Abs(k1 - k2) < double.Epsilon && Math.Abs(b1 - b2) < double.Epsilon)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (Math.Abs(k1 - k2) < double.Epsilon && Math.Abs(b1 - b2) > double.Epsilon)
    {
        Console.WriteLine("Прямые паралельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({Math.Round(x, 5)}; {Math.Round(y, 5)})");
    }
}

Console.Clear();
Console.WriteLine("Задайте параметры прямых в виде коэффициентов");
Console.WriteLine("для уравнений вида y1=k1*x+b1 и y2=k2*x+b2");
Cross();