/*/
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*/
int[,]mtrx=CreateMatrix(4,3);
int minrow=FindMinRow(mtrx);
PrintMatrix(mtrx);
Console.WriteLine();
Console.WriteLine($"{minrow} строка");

int FindMinRow(int [,]matrix)
{
    int min=0;
    int sum=0;
    int n=0;


     for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
           sum=sum+matrix[row,col];
        }
        if (row==0) {min=sum; n=row;}
        if (min>sum) {min=sum; n=row;}
        sum=0;
    }
return n+1;
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