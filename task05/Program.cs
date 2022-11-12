/*/
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
/*/

int[,] matrix = CreateMatrix(4, 4);

int length = matrix.GetLength(1);
int height = matrix.GetLength(0);

int[] position = { 0, 0 };
int hor = length - 1;
int ver = height - 1;
int count = hor*ver; 
int value = 01;

matrix[0, 0] = value;

value++;

for (int i = 0; i < hor; i++)
{
    MoveRight(position);
    matrix[position[0], position[1]] = value;
    value++;
}
for (int i = 0; i < ver; i++)
{
    MoveDown(position);
    matrix[position[0], position[1]] = value;
    value++;
    
}
ver--;

while (count > 0)
{  

    for (int i = 0; i < hor; i++)
    {
        MoveLeft(position);
        matrix[position[0], position[1]] = value;
        value++;
        count--;
    }
    hor--;
    if (count<1) break;
    for (int i = 0; i < ver; i++)
    {
        MoveUp(position);
        matrix[position[0], position[1]] = value;
        value++;
        count--;
    }
    ver--;
    if (count<1) break;
    for (int i = 0; i < hor; i++)
    {
        MoveRight(position);
        matrix[position[0], position[1]] = value;
        value++;
        count--;
    }
    hor--;
    if (count<1) break;
    for (int i = 0; i < ver; i++)
    {
        MoveDown(position);
        matrix[position[0], position[1]] = value;
        value++;
        count--;
    }
    ver--;
    if (count<1) break;
}
PrintMatrix(matrix);

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
            //Console.Write($"{matrix[row, col]}  ");
           Console.Write( string.Format("{0:d2}  ", matrix[row, col]));
        }
        Console.WriteLine();
    }
}