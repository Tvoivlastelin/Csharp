Console.WriteLine("Введите колличество элементов в массиве");
int element = Convert.ToInt32(Console.ReadLine());
    int [] myArray = new int[element];
     int count = 0;
 
      for(int i=0;i<myArray.Length;i++)
      {
         Console.WriteLine($"Введите число масcива с индексом {i}");
         myArray[i]=Convert.ToInt32(Console.ReadLine());
         if(myArray[i]>0)
         count++;
      }
      Console.WriteLine($"[{string.Join(", ", myArray)}] -> {count}");
