// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

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
int m = ReadNumber("Введите кол-во строк");
int n = ReadNumber("Введите кол-во столбцов");

int[,] myMatrix = RandomMatrix(m, n);
PrintMatrix(myMatrix);

int pi = ReadNumber("Введите позицию числа по строке");
int pj = ReadNumber("Введите позицию числа по столбцу");

bool val = true;
for (int i = 0; i < myMatrix.GetLength(0); i++)
{
    for (int j = 0; j < myMatrix.GetLength(1); j++)
    {
        if (pi < m || pj < n)
        {
            val = true;
        }
        else
        {
            val = !val;
        }
    }
}
if (val == true)
{
    Console.WriteLine(myMatrix[pi, pj]);
}
else
{
    Console.WriteLine("такого числа в массиве нет");
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


