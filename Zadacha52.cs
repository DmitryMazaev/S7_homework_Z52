/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

void ArMean(int[,] inArray)
{
    double a = 0;
    int i = 0;
    int j = 0;
    
    for  (j = 0; j < inArray.GetLength(1); j++)
    {
        for  (i = 0; i < inArray.GetLength(0); i++)
        {
            if (i == 0)
            {
                a = inArray [i,j];
            }
            else
            {
                a = a + inArray [i,j];
            }
        }
        double result = Math.Round(a/inArray.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое столбца {j} = {result} ");
    }
    
}

ArMean(array);