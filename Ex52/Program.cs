// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double[] SrArifm(int[,] array)
{
    double[] res = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {    
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res[j] = res[j] + array[i,j];
        }
        res[j] = res[j] / array.GetLength(0);
    }
    return res;
}

int[,] res = Create2DArray(3,4);
Print2DArray(res);
double[] res2 = SrArifm(res);
PrintArray(res2);