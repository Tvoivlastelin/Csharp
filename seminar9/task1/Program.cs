// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 8;
void NumbersOtNToOne(int n)
{
    if (n == 0) return;
    else
    {

        NumbersOtNToOne(n - 1);
        Console.Write(number - n + 1 + ", ");
    }
}
NumbersOtNToOne(number);
