// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

/// summary - описание метода
/// m - строчки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
return matrix;
}
/// PrintArray: int [,] matrix
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
int FindMinSumRow(int[,] inputMatrix)
{
    int IndexminSumRow = 0;
    int minSumRow = 9999;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputMatrix.GetLength(1); j++) 
        {
           sum += inputMatrix[i, j];
        }
        Console.WriteLine("сумма строки " + i + " = " + sum );
        if (sum < minSumRow)
        {
            minSumRow = sum;
            IndexminSumRow = i;
        }

    }
    return IndexminSumRow;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

int NumberRow = FindMinSumRow(resultMatrix);
Console.WriteLine("Результат: "+ NumberRow + " строка" );
