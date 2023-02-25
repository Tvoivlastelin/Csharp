// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] GetRandomArray(int length, int leftRange,int rightRange)
{
    int [] array = new int [length];
    for(int i=0; i<length;i++)
    {
        array[i]=Random.Shared.Next(leftRange,rightRange);
    
    }
    return array;
}
int[] myArray = GetRandomArray(8,1,100);
int max = myArray[0];
int FindMaxArray(int [] array, int max)
{
    for(int i=0; i<array.Length;i++)
    {
       if(array[i]>max)
       {
        max=array[i];
       }
    }
    return max;
}
int min = myArray[0];
int FindMinArray(int [] array, int min)
{
    for(int i=0; i<array.Length;i++)
    {
       if(array[i]<min)
       {
        min=array[i];
       }
    }
    return min;
}

Console.WriteLine($"[{string.Join( ", " , myArray)}]");

int maximum = FindMaxArray(myArray,max);
Console.WriteLine("максимальное число -> " + maximum);
int minimum = FindMinArray(myArray,min);
Console.WriteLine("минимальное число -> " + minimum);
int raz = maximum-minimum;
Console.WriteLine("разница между макс и мин -> " + raz);

