// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// (номер цифры считается от левого края)

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// 2147483647

Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num>99)
{
while (num>999)
{
    num = num / 10;
}

Console.WriteLine(num % 10);
}
else 
{
    
Console.WriteLine("третьего числа нет");
}
//  string mas =  Convert.ToString(number);

// if (mas.Length>=3)
// {
//     Console.WriteLine(mas[2]);
// }
// else
// {
//     Console.WriteLine("третьего числа нет");
// }
