// Напишите программу вычисления 
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int m = ReadNumber("Введите m");
int n = ReadNumber("Введите n");

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return FunctionAkkerman(m - 1, 1);
    else
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    
}
Console.WriteLine($"A({m},{n}) = {FunctionAkkerman(m, n)}");
