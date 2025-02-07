﻿double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void WriteArrayToConsole(double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] GetMultArray(double[,] firstArray, double[,] secondArray)
{
    double[,] resultArray = new double[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = Math.Round(resultArray[i, j], 2);
        }
    return resultArray;
}

int rows1 = 3;
int colums1 = 5;
int rows2 = colums1;
int colums2 =4;
double[,] Array1 = GetArray(rows1, colums1, -10, 10);
double[,] Array2 = GetArray(rows2, colums2, -10, 10);
double[,] result = GetMultArray(Array1, Array2);

Console.WriteLine("Первый массив: ");
WriteArrayToConsole(Array1);
Console.WriteLine("Второй массив: ");
WriteArrayToConsole(Array2);
Console.WriteLine("Их произведение: ");
WriteArrayToConsole(result);