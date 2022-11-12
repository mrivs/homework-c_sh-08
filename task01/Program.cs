/*/
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
/*/

int[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);
Console.WriteLine();
BinarySortRows(matrix);
PrintMatrix(matrix);

void BinarySortRows(int[,] matrix)
{
    int length = matrix.GetLength(1);
    int key;
    int j;
    int loc;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            j = col - 1;
            key = matrix[row,col];
            loc = binarySearchForSort(matrix,row, key, 0, j);
            while (j >= loc)
            {
                matrix[row,j + 1] = matrix[row,j];
                j = j - 1;
            }
            matrix[row,j + 1] = key;
        }
    }
}

int binarySearchForSort(int[,] array,int row, int item, int low, int high) // Бинарный поиск для сортировки 2 мерного массива
{
    while (low <= high)
    {
        int mid = low + (high - low) / 2;
        if (item == array[row,mid])
            return mid+1 ;
        else if (item < array[row,mid])  
            low = mid + 1;
        else
            high = mid - 1;
    }
    return low;
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