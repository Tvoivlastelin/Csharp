// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int ReadNumber(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int ax = ReadNumber("Введите ккординату точки A по оси X");
int ay = ReadNumber("Введите ккординату точки A по оси Y");
int az = ReadNumber("Введите ккординату точки A по оси Z");
int bx = ReadNumber("Введите ккординату точки B по оси X");
int by = ReadNumber("Введите ккординату точки B по оси Y");
int bz = ReadNumber("Введите ккординату точки B по оси Z");

 double ans = Math.Sqrt(Math.Pow(bx-ax,2) + Math.Pow(by-ay,2) + Math.Pow(bz-az,2));
 Console.WriteLine(Math.Round(ans,2));