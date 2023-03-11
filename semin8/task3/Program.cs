// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] newMatrix = RandomMatrix(m, n);

PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(newMatrix);

int[,] ProMatrix = new int[m, n];

int[,] ProizvMatrix(int[,] myMatrix, int[,] newMatrix, int[,] Promatrix)
{
    for (int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(1); j++)
        {
            Promatrix[i, j] = myMatrix[i, j] * newMatrix[i, j];
        }
    }
    return Promatrix;
}
int[,] Proma = ProizvMatrix(myMatrix,newMatrix,ProMatrix);
Console.WriteLine();
PrintMatrix(Proma);