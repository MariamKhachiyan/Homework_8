﻿// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


/*Console.WriteLine("Enter dimension");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter dimension");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[,] matrixBeforeSort = new int[m, n];
int[,] matrixAfterSort = new int[m, n];
int[] sort = new int[n];

int[,] FillArray(int[,] arr) 
{
    for (int rows = 0; rows < arr.GetLength(0); rows++) 
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            arr[rows, columns] = rand.Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            Console.Write(arr[rows, columns] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] arr)
{
    for (int rows = 0; rows < matrixBeforeSort.GetLength(0); rows++)
    {
        for (int columns1 = 0; columns1 < matrixBeforeSort.GetLength(1); columns1++)
            sort[columns1] = arr[rows, columns1];
        Array.Sort(sort);
        Array.Reverse(sort);
        for (int columns2 = 0; columns2 < matrixBeforeSort.GetLength(1); columns2++)
        {
            arr[rows, columns2] = sort[columns2];
        }
    }
    return arr;
}

Console.WriteLine("--------------------------------------------------"); 
PrintArray(FillArray(matrixBeforeSort));
matrixAfterSort = matrixBeforeSort;
Console.WriteLine("--------------------------------------------------");
PrintArray(SortArray(matrixAfterSort)); */


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


/* Console.WriteLine("Enter dimension:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter dimension:");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int[,] matrix = new int[m, n];

int[,] FillArray(int[,] arr) 
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            arr[rows, columns] = rand.Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            Console.Write(arr[rows, columns] + " ");
        }
        Console.WriteLine();
    }
}

int MinSumInRow(int[,] arr) 
{
    int[] HelpArray = new int[arr.GetLength(0)]; 
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        int sum = 0;
        for (int columns = 0; columns < arr.GetLength(1); columns++)
        {
            sum = sum + arr[rows, columns];
        }
        HelpArray[rows] = sum;
    }
    int min = HelpArray.Min();
    int outRow = Array.IndexOf(HelpArray, min);
    return outRow;
}
Console.WriteLine("--------------------------------------------------");
PrintArray(FillArray(matrix));
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Raw with lowest amount of elements: " + (MinSumInRow(matrix) + 1)); */



/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4   6 12
3 2 | 3 3   12 
Результирующая матрица будет:
18 20
15 18
 */

 /* int[,] ProducTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix1.GetLength(1); k++) 
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandomArray2D(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows1 = PromptNumber("Enter first matrix's amount of raws: ");
int cols1 = PromptNumber("Enter first martix's amoount of columns: ");
int rows2 = PromptNumber("Enter second matrix's amount of raws:");
int cols2 = PromptNumber("Enter second martix's amoount of columns: ");
Console.WriteLine();
if (cols1 != rows2)
{
    Console.WriteLine(@"Enter equal dimensions.");
    return;
}
int[,] mas1 = GenerateRandomArray2D(rows1, cols1, 1, 10);
int[,] mas2 = GenerateRandomArray2D(rows2, cols2, 1, 10);
int[,] resultMas = ProducTwoMatrix(mas1, mas2);
Console.WriteLine("Fisrt matrix");
PrintArray2D(mas1);
Console.WriteLine();
Console.WriteLine("Second matrix");
PrintArray2D(mas2);
Console.WriteLine();
Console.WriteLine("Resultant matrix");
PrintArray2D(resultMas); */



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/* int[,,] array3D = new int[2, 2, 2];

void FillArray(int[,,] array)


 {
     int count = 10;
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             for (int k = 0; k < array.GetLength(2); k++)
             {
                 array[i, j, k] += count;
                 count += 1;
             }
         }
     }
 }



{
    Random random = new Random();
    List<int> numbers = new List<int>();

    for (int i = 10; i <= 101; i++)
    {
        numbers.Add(i);
    }

    for (int i = numbers.Count - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }

    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = numbers[index];
                index++;
            }
        }
    }
}


void PrintIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]:D2}({i},{j},{k}) ");
            }
        }
    }
}

FillArray(array3D);
PrintIndex(array3D); */


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/* int numMatrix = 4;
int[,] spiraleMatrix = new int[numMatrix, numMatrix];

int k = 1;
int i = 0;
int j = 0;

while (k <= numMatrix * numMatrix)
{
    spiraleMatrix[i, j] = k;
    if (i <= j + 1 && i + j < numMatrix - 1)
        ++j;
    else if (i < j && i + j >= numMatrix - 1)
        ++i;
    else if (i >= j && i + j > numMatrix - 1)
        --j;
    else
        --i;
    ++k;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("D2") + " ");
        }
        Console.WriteLine("");
    }
}

PrintArray(spiraleMatrix); */