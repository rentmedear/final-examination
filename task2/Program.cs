
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.Write("Введите первое число(M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число(N): ");
int n = Convert.ToInt32(Console.ReadLine());


if (m < 1 || n < 1)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}
if (m > n)
{
    Console.WriteLine("Введите значения в другом порядке!");
    return;
}

SumRangeNumbers(m, n);

void SumRangeNumbers(int m, int n)
{
    Console.Write(SumRN(m - 1, n));
}

int SumRN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumRN(m, n);
        return res;
    }
}





