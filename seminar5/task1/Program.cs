//  Задайте массив заполненный случайными положительными 
//  трёхзначными числами. Напишите программу, которая 
//  покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] GetRandomArray(int length, int leftRange,int rightRange)
{
    int [] array = new int [length];
    for(int i=0; i<length;i++)
    {
        array[i]=Random.Shared.Next(leftRange,rightRange);
    
    }
    return array;
}

int[] myArray = GetRandomArray(4,100,1000);

    int chet =0;
    for(int i=0; i<myArray.Length;i++)
    {
        if(myArray[i]%2 ==0)
        {
            chet=chet+1;
        }
    }
Console.WriteLine($"[{string.Join( ", " , myArray)}]" + " -> " +  chet);

