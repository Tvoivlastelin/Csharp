// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите любое пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

 int num1 = 0;
 int num2 = 0;
 int num4 = 0;
 int num3 = 0;

 if (num>10000 && num<99999)
 {
     num1 = num / 10000;
     num2 = num % 10;
     num3 = num / 1000;
     num3 = num3 % 10;
     num4 = num / 10;
     num4 = num4 % 10;

 if (num1==num2 && num3 == num4)
 {
     Console.WriteLine("Да, число палиндром");
 }
 else
 {
 Console.WriteLine("Нет, число не палиндром");
 }
 }
 else 
 {
     Console.WriteLine("Введите именно пятизначное число");
 }