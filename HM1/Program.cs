//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();
{
WriteLine("Введите номера строк и столбцов через пробел: ");
string[] rowColumn = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);;
int row1 = int.Parse(rowColumn[0]);
int column1 = int.Parse(rowColumn[1]);

double[,] myArray = GetRandomArray(row1, column1);
PrintArray(myArray);
double[,] GetRandomArray(int rows, int columns)
{
    double[,] result = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            result[i, k] = new Random().Next(-50,50) + new Random().NextDouble();
        }
    }
    return result;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            Write($"{arr[i, k].ToString("F3")} ");
        }
        WriteLine();
    }
}


}
