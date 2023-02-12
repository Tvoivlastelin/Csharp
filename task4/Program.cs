// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое число ");

string answer = Console.ReadLine();
int n= Convert.ToInt32(answer);

Console.WriteLine("Cейчас появятся все четные числа");
for (int i=2; i<=n; i=i+2)
{
    Console.Write (i);
    Console.Write(",");
}