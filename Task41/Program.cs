// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите числа (через пробел): ");
    string number = Console.ReadLine()!;
    int[] array = CreateArray(number, ' ');
    int res = Zero(array);
    Console.WriteLine($" --> {res}");
}

int[] CreateArray(string list, char cut)
{
    int[] newList = list.Split(' ').Select(int.Parse).ToArray();
    Console.Write($"[{String.Join(", ", newList)}]");
    return newList;
}


int Zero(int[] num)
{
    int result = 0;
    foreach (int el in num)
    {
        if (el > 0)
            result++;
    }
    return result;
}

Main();