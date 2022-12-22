// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void CountDictionary(int[,] arr)
{
    int count = 0;
    for (int n = 0; n < 10; n++)  // Проверяет только от 0 до 9, 
    // чтобы проверяло больше чисел вместо 10 ставим границы рандомных чисел leftrange и rightrange
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (n == arr[i, j])
                {
                    count++;
                }
            }
        }
        if (count > 0)
        {
            System.Console.WriteLine($"число {n} встречается {count}");
            count = 0;
        }
        else
        {
            count = 0;
        }
    }
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
CountDictionary(matrix);
