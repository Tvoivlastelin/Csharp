// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");

string answerA = Console.ReadLine();
int max = Convert.ToInt32(answerA); 

Console.WriteLine("Введите второе число ");

string answerB = Console.ReadLine();
int b = Convert.ToInt32(answerB); 

Console.WriteLine("Введите третье число ");

string answerС = Console.ReadLine();
int c = Convert.ToInt32(answerС); 


if (max <= b)
{
  if (b <= c)
  {
      Console.WriteLine(" - > " + c + ".");
  }
  else Console.WriteLine(" - > " + b + ".");
}
else  
 if (max > c)
 {
     Console.WriteLine(" - > " + max + ".");
 }
 else Console.WriteLine(" - > " + c + ".");