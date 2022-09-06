// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы" );
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы" );
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы" );
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы" );
int columnsB = Convert.ToInt32(Console.ReadLine());

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

int[,] Multiplication(int[,] a, int[,] b)
        {
            
            int[,] result = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        result[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return result;
        }

int[,] MatrixA = GetArray(rowsA, columnsA);
int[,] MatrixB = GetArray(rowsB, columnsB);
PrintArray(MatrixA);
Console.WriteLine();
PrintArray(MatrixB);
Console.WriteLine();

if (MatrixA.GetLength(1) != MatrixB.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
else 
    {
        int[,] MatrixC = Multiplication(MatrixA, MatrixB);
        PrintArray(MatrixC);
    }