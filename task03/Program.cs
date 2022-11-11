/*/
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
/*/

int[,] A = CreateMatrix(2, 2);
int[,] B = CreateMatrix(2, 2);
Console.WriteLine("Матрица А");
PrintMatrix(A);
Console.WriteLine("Матрица B");
PrintMatrix(B);
Console.WriteLine("Матрица A*B");

if (A.GetLength(1) == B.GetLength(0))
{
    int[,] C = MultuplicateMatrix(A, B);
    PrintMatrix(C);
}
else { Console.WriteLine("Неверные матрицы"); }

int[,] MultuplicateMatrix(int[,] A, int[,] B) // умножаем матрицы A*B;
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    int value = 0;
    for (int row = 0; row < C.GetLength(0); row++)
    {
        for (int col = 0; col < C.GetLength(1); col++)
        {
            for (int i = 0; i < A.GetLength(1); i++)
            {
                value = value + A[row, i] * B[i, col];
            }
            C[row, col] = value;
            value=0;
        }

    }
    return C;
}

int[,] CreateMatrix(int m, int n) // создаем матрицу
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            matrix[row, col] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // отображаем матрицу
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]}  ");
        }
        Console.WriteLine();
    }
}