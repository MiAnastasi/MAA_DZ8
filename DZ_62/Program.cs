﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размерность квадратной матрицы" );
int rows = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, rows];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= rows*rows)
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < rows - 1) j++;
    else if (i < j && i + j >= rows - 1) i++;
    else if (i >= j && i + j > rows - 1) j--;
    else i--;
}

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);

