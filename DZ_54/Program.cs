//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            Console.Write(matrix[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}
void SortRows(int[,] inputMatrix)
{
    
    for (int k = 0; k < inputMatrix.GetLength(0); k++)
    {
        for (int i = 0; i < inputMatrix.GetLength(1) - 1; i++) 
        {
            for (int j = i + 1; j < inputMatrix.GetLength(1); j++) 
            {
                if (inputMatrix[k, i] < inputMatrix[k, j])
                {
                    int temp = inputMatrix[k, i];
                    inputMatrix[k, i] = inputMatrix[k, j];
                    inputMatrix[k, j] = temp;
                }
            }
        }
    }
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Результат: ");
SortRows(resultMatrix);
PrintArray(resultMatrix);
