// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");

string answer = Console.ReadLine();
int a = Convert.ToInt32(answer); 

int b = a % 2;
 
if (b == 0) 
 {
     Console.WriteLine("да!");
 }
 else Console.WriteLine("нет!");