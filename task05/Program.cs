/*/
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
/*/

int[,] matrix = CreateMatrix(4, 4);
SetSpiral(matrix);
PrintMatrix(matrix);

void SetSpiral(int[,] matrix)  // пишем спираль в двумерный массив (работает и для прямоугольных массивов ;)
{
    int[] position = { 0, 0 };
    int horz = matrix.GetLength(1);
    int vert = matrix.GetLength(0);
    int count = horz * vert;
    int value = 1;
    bool firsttime = true;

    while (count > 0)
    {
        for (int i = 0; i < horz - 1; i++)
        {
            matrix[position[0], position[1]] = value;
            value++;
            count--;
            MoveRight(position);
        }

        if (firsttime) { horz++; firsttime = false; }
        horz--;
        if (count == 1) break;
        for (int i = 0; i < vert - 1; i++)
        {
            matrix[position[0], position[1]] = value;
            value++;
            count--;
            MoveDown(position);
        }
        vert--;
        if (count == 1) break;
        for (int i = 0; i < horz - 1; i++)
        {
            matrix[position[0], position[1]] = value;
            value++;
            count--;
            MoveLeft(position);
        }
        horz--;
        if (count == 1) break;
        for (int i = 0; i < vert - 1; i++)
        {
            matrix[position[0], position[1]] = value;
            value++;
            count--;
            MoveUp(position);
        }
        vert--;
        if (count == 1) break;
    }
    matrix[position[0], position[1]] = value;
}

int[,] CreateMatrix(int m, int n) // создаем матрицу
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            // matrix[row, col] = rnd.Next(0, 10);
            matrix[row, col] = 0;
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
            Console.Write(string.Format("{0:d2} ", matrix[row, col]));
        }
        Console.WriteLine();
    }
}
void MoveRight(int[] position)
{
    position[1]++;
}
void MoveLeft(int[] position)
{
    position[1]--;
}
void MoveUp(int[] position)
{
    position[0]--;
}
void MoveDown(int[] position)
{
    position[0]++;
}