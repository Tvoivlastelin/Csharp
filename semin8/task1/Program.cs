﻿//  Задайте двумерный массив. Напишите программу, 
//  которая упорядочит по возрастанию элементы каждой 
//  строки двумерного массива.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 9)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftborder, rightborder + 1);
        }

    }
    return matrix;
}


int[,] RowsMinToMax(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                {
                    newMatrix = matrix;
                    if (matrix[i, j] <= matrix[i, k])
                    {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                    }
                }
            }
        }

    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int[,] myMatrix = GetRandomMatrix(m, n);

PrintMatrix(myMatrix);
Console.WriteLine();
int[,] transform = RowsMinToMax(myMatrix);
PrintMatrix(transform);
