// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] RandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }
    return matrix;
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
int m = ReadNumber("Введите кол-во строк");
int n = ReadNumber("Введите кол-во столбцов");

int[,] myMatrix = RandomMatrix(m, n);

PrintMatrix(myMatrix);

int[] Sum = new int[myMatrix.GetLength(0)];
int[] SumElementInRow(int[,] matrix, int[] Sum)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum[i] = Sum[i] + matrix[i, j];
        }
        Console.WriteLine(Sum[i]);
    }
    return Sum;
}
int[] Summa = SumElementInRow(myMatrix, Sum);

int IndexOfMinRows(int[] Sum, int ind = 0)
{
    int min = Sum[0];
    for (int i = 0; i < Sum.Length; i++)
    {
        if (Sum[i] <= min)
        {
            min = Sum[i];
            ind = i;
        }
    }
    return ind;
}
int Indd = IndexOfMinRows(Summa);
Console.WriteLine($"минимальная сумма на строке --> {Indd + 1}");
