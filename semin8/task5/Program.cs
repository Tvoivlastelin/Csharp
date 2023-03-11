// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int m = ReadNumber("Введите кол-во строк");
int n = ReadNumber("Введите кол-во столбцов");
int[,] matrix = new int[m, n];

int[,] Spiral(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            {
                matrix[0, j] = j + 1;
                matrix[i, matrix.GetLength(1) - 1] = matrix[0, matrix.GetLength(1) - 1] + i;
            }
            int count = 1;
            for (int k = matrix.GetLength(0) - 2; k >= 0; k--)
            {
                matrix[matrix.GetLength(0) - 1, k] = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1] + count;
                count++;
                int count1 = 1;
                for (int l = matrix.GetLength(0) - 2; l >= 1; l--)
                {
                    matrix[l, 0] = matrix[matrix.GetLength(0) - 1, 0] + count1;
                    count1++;
                    for (int m = 1; m <= matrix.GetLength(1) - 2; m++)
                    {
                        matrix[1, m] = matrix[1, m - 1] + 1;

                        for (int n = 1; n < matrix.GetLength(0) - 2; n++)
                        {
                            matrix[n + 1, matrix.GetLength(1) - 2] = matrix[n, matrix.GetLength(1) - 2] + 1;

                            int count2 = 1;
                            for (int h = matrix.GetLength(0) - 3; h >= 1; h--)
                            {
                                matrix[matrix.GetLength(0) - 2, h] = matrix[matrix.GetLength(0) - 2, matrix.GetLength(1) - 2] + count2;
                                count2++;
                            }
                        }
                    }
                }
            }
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
int[,] Spir = Spiral(matrix);

PrintMatrix(Spir);