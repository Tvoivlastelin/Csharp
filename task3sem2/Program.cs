// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


 Console.WriteLine("Введите день недели");
 int number = Convert.ToInt32(Console.ReadLine());

 if (number < 1 || number > 8 )
{
  Console.WriteLine("Нет такого дня недели");
 }
  else 
 {
     if (number>5)
     {
     Console.WriteLine("да");
     }
     else
    {
         Console.WriteLine("нет");
     }
 } 