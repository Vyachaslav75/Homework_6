int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}
string enterNumberStr(string msg, string errorMsg)
{
    string number;
    while (true)
    {
        Console.Write(msg);
        number = Console.ReadLine() ?? "";
        if (int.TryParse(number, out int num) || CheckChar(number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}

int[] fillArray_1()
{
    int N = enterNumber("Введите количество чисел:  ", "Введите целое число");
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = enterNumber("Введите число:  ", "Введите целое число");
    }
    return array;
}


int[] fillArray_2()
{
    int[] array = new int[0];
    string tmp;
    int ind = 0;
    Console.WriteLine("Вводите числа после приглашения.");
    Console.WriteLine("Для окончания ввода введите q или Q");
    while (true)
    {
        tmp = enterNumberStr("Введите число:  ", "Введите целое число");
        if (CheckChar(tmp))
        {
            break;
        }
        Array.Resize(ref array, array.Length + 1);
        array[ind] = int.Parse(tmp);
        ind++;
    }
    return array;
}


int[] fillArray_3()
{
    int size = enterNumber("Введите количество элементов массива:  ", "Введите целое число");
    int minValue = enterNumber("Введите нижнюю границу:  ", "Введите целое число");
    int maxValue = enterNumber("Введите верхнюю границу:  ", "Введите целое число");
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}


bool CheckChar(string usChar)
{
    if (usChar == "q" || usChar == "Q")
    {
        return true;
    }
    else
    {
        return false;
    }
}


int PositiveCount(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

int[] FillNumbers(int num)
{
    if (num == 1)
    {
        return fillArray_1();
    }
    else if (num == 2)
    {
        return fillArray_2();
    }
    else if (num == 3)
    {
        return fillArray_3();
    }
    int[] arr=new int[0];
    return arr;
}

Console.Clear();
Console.WriteLine("Числа можно вводить тремя способами.");
Console.WriteLine("Чтобы ввести количество чисел и сами числа введите 1");
Console.WriteLine("Чтобы вводить числа, пока не введете q или Q введите 2");
Console.WriteLine("Чтобы ввести количество чисел и диапазон для их случайного ввода введите 3");
int methodFill = enterNumber("Выберите способ заполнения массива:  ", "Введите целое число от 1 до 3");
int[] userArray = FillNumbers(methodFill);
Console.WriteLine($"{String.Join(", ", userArray)} -> {PositiveCount(userArray)}");