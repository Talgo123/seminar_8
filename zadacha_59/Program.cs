// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void NewArray(int[,] arr, int minRow, int minColumn)
{
    int newLengthI = arr.GetLength(0) - 1;
    int newLengthJ = arr.GetLength(1) - 1;
    int[,] newArray = new int[newLengthI, newLengthJ];
    int m = 0;
    int n = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == minRow)
        {
            continue;
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == minColumn)
            {
                continue;
            }
            newArray[m, n] = arr[i, j];
            n++;
        }
        m++;
        n = 0;
    }
    ShowArray(newArray);
}

void FindMin(int[,] arr)
{
    int min = arr[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < min)
            {
                min = arr[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    NewArray(arr, minRow, minColumn);
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNUmber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNUmber("Введите значение M: ");
int n = EnterNUmber("Введите значение N: ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
ShowArray(matrix);
System.Console.WriteLine();
FindMin(matrix);
