// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
{
int[,] myArray = GetRandomArray(10,10);
WriteLine("Пожалуйста, добавьте позицию (  номер строки, номер столбца через пробел: ");
string[] arraySize = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int row1 = int.Parse(arraySize[0]);
int column1 = int.Parse(arraySize[1]);

if(row1<= myArray.GetLength(0) || column1<=myArray.GetLength(1))
        WriteLine($"Значение элемента: {myArray[row1,column1]}");
    else
        WriteLine("Нет такого элемент в массиве");
PrintArray(myArray);


int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            result[i, k] = new Random().Next(-50,50);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Write($"{array[i, k] } ");
        }
        WriteLine();
    }
}


}