// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

void Main()
{
    Console.Clear();
    int[,] matrix = new int[4, 5];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    PrintConterClock(matrix);
}

void FillArray(int[,] matr)
{
    for (int i1 = 0; i1 < matr.GetLength(0); i1++)
    {
        for (int j1 = 0; j1 < matr.GetLength(1); j1++)
        {
            matr[i1, j1] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] mr)
{
    for (int i1 = 0; i1 < mr.GetLength(0); i1++)
    {
        for (int j1 = 0; j1 < mr.GetLength(1); j1++)
        {
            Console.Write($"{mr[i1, j1]} ");
        }
        Console.WriteLine();
    }
}

void PrintConterClock(int[,] spiral)
{
    int col = spiral.GetLength(0);
    int row = spiral.GetLength(1);
    int[] array = new int[col * row];
    int index = 0;
    for (int count = 0; index < col * row; count++)
    {
        int i = col - count - 1;
        int j = count;
        while (j < row - count)
        {
            array[index] = spiral[i, j];
            j++;
            index++;
        }
        if (index == col * row) 
        {
            break;
        }
        j--;
        i--;
        while (i > count)
        {
            array[index] = spiral[i, j];
            i--;
            index++;
        }
        if (index == col * row) 
        {
            break;
        }
        while (j > count)
        {
            array[index] = spiral[i, j];
            j--;
            index++;
        }
        if (index == col * row) 
        {
            break;
        }
        while (i < col - count - 1)
        {
            array[index] = spiral[i, j];
            i++;
            index++;
        }
    }
    Console.WriteLine(String.Join(", ", array));
}

Main();