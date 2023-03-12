// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 4;
int n = 8;

int SumDigit(int min, int max)
{
    int sum = max;
    if (min == max) return min;
    else
    {
        sum = sum + SumDigit(min, max - 1);
    }
    return sum;
 
}
Console.WriteLine(SumDigit(m, n));


