 /*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void RowsRegulate(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  PrintMatrix(array);
}
int row = 0;
int col = 0;
while (row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while (col <= 0)
{
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();
RowsRegulate(matrix);
*/
////
/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrixWithRandom(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void LessSum(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow[i] += array[i, j];
        }
    }
    Console.WriteLine($"[{string.Join(", ", sumRow)}]");
    int minIdx = 0;
    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[minIdx] > sumRow[i])
        {
            minIdx = i;
        }
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {minIdx}");
}
int row = 0;
int col = 0;
while (row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while (col <= 0)
{
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = FillMatrixWithRandom(row, col);
PrintMatrix(matrix);
Console.WriteLine();
LessSum(matrix);
*/
////
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int[,,] Fill3dWithRandom(int row, int col, int elements)
{
    int[,,] array = new int[row, col, elements];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(0, 10);
            }
        }
    }
    return array;
}

void Print3d(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
int row = 0;
int col = 0;
int elements = 0;
while (row <= 0)
{
    Console.Write("Введите кол-во строк: ");
    row = Convert.ToInt32(Console.ReadLine());
}
while (col <= 0)
{
    Console.Write("Введите кол-во столбцов: ");
    col = Convert.ToInt32(Console.ReadLine());
}
while (elements <= 0)
{
    Console.Write("Введите кол-во элементов: ");
    elements = Convert.ToInt32(Console.ReadLine());
}
int[,,] array3d = Fill3dWithRandom(row, col, elements);
Print3d(array3d);
*/
////

