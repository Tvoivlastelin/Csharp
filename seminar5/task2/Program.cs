//  Задайте одномерный массив, 
//  заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] GetRandomArray(int length, int leftRange,int rightRange)
{
    int [] array = new int [length];
    for(int i=0; i<length;i++)
    {
        array[i]=Random.Shared.Next(leftRange,rightRange);
    
    }
    return array;
}
int Sum =0;
int SumNumberNechIndexArray(int [] array, int Sum)
{
    for(int i=0; i<array.Length;i++)
    {
       if(i%2!=0)
       {
        Sum = Sum + array[i];
       }
    }
    return Sum;
}

int[] myArray = GetRandomArray(6,-9,10);
int summa = SumNumberNechIndexArray(myArray, Sum);
Console.WriteLine($"[{string.Join( ", " , myArray)}] -> " + summa);
