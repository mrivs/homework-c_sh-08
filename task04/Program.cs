/*/
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
/*/

int[,,]arr=CreateTdmArray();
PrintTdmArray(arr);

int[,,] CreateTdmArray()
{
    int[,,] tdmArray = new int[2, 2, 2];
    int value = 10;
    for (int i = 0; i < tdmArray.GetLength(0); i++)
    {
        for (int j = 0; j < tdmArray.GetLength(1); j++)
        {
            for (int k = 0; k < tdmArray.GetLength(2); k++)
            {
                tdmArray[i, j, k] = value;
                value++;
            }
        }
    }
    return tdmArray;
}

void PrintTdmArray(int[,,] tdmArray)
{
for (int i = 0; i < tdmArray.GetLength(0); i++)
    {
        for (int j = 0; j < tdmArray.GetLength(1); j++)
        {
            for (int k = 0; k < tdmArray.GetLength(2); k++)
            {
                Console.Write($"{tdmArray[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}