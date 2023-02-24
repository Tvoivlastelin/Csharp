// Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum =0;
// string mas =  Convert.ToString(num);
// for (int i=0; i<mas.Length; i++)
//   {
//     sum = sum + mas[i];
//   }
// Console.Write(sum);

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int number)
{
    int sum = 0;
    while ( number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
int num = ReadNumber("введите число");
int res = SumOfDigits(num);
Console.WriteLine(res);
