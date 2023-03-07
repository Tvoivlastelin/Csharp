// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.WriteLine();

for (int j = 0; j < myMatrix.GetLength(1); j++)
{
    double sum = 0;
    double sra = 0;
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        sum = sum + myMatrix[i, j];
        sra = sum / myMatrix.GetLength(0);
    }
    Console.Write(Math.Round(sra, 2) + "; ");
}
