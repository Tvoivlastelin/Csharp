// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}
double b1 = ReadNumber("Введите значение b1");
double k1 = ReadNumber("Введите значение k1");
double b2 = ReadNumber("Введите значение b2");
double k2 = ReadNumber("Введите значение k2");

double p1 =0;
double p2=0;
 if (k1 == k2)
 {
    Console.WriteLine("прямые параллельны или совпалают?хз");
 }
 
p1=(b2-b1)/(k1-k2);
p2=(k1*b2-k2*b1)/(k1-k2);
Console.WriteLine($"p = ({p1};{p2})");