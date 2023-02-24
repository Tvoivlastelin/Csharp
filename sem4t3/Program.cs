// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int a = ReadNumber("введите первое число");
// int b = ReadNumber("введите второе число");
// int c = ReadNumber("введите третье число");
// int d = ReadNumber("введите четвертое число");
// int e = ReadNumber("введите пятое число");
// int f = ReadNumber("введите шестое число");
// int g = ReadNumber("введите седьмое число");
// int h = ReadNumber("введите восьмое число");


//     int [] array = {a,b,c,d,e,f,g,h};
//       Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + ",");
// }
//   Console.Write(array[array.Length-1]);
//     Console.Write("]");


 Console.WriteLine("Введите число");
 int Len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max");
 int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min");
 int min = Convert.ToInt32(Console.ReadLine());

int [] array = new int [Len];
Random random = new Random();
 Console.Write("[");
for (int i =0; i<Len; i++)
{
    array[i] =random.Next(min,max);
    Console.Write(array[i]+",");
}
Console.Write(array[array.Length-1]);
Console.Write("]");

