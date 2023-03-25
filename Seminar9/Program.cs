
void PrintNumberToN(int N)
{
    if (N == 0)
    {
        return;
    }
    PrintNumberToN(N - 1);
    Console.Write($"{N} ");
}

Console.Write("Input nuber: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(number);

/*
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
void PrintNumberToN(int N)
{
if(N == 0)
{
return;
}
PrintNumberToN(N - 1);
System.Console.Write($"{N} ");
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(number);

Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

void Numbers(int M, int N)
{
if (M - 1 == N)
{
    return;
}

Numbers(M, N - 1);
Console.Write($"{N} ");
}
Numbers(20, 4);


/ Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumRec(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + SumRec(number/10);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumRec(number));

Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

int MultNumber(int N, int M)
{
    if (M == 0)
    {
        return 1;
    }
    return N*MultNumber(N,M-1);
}

int PowAB(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }    
    return a * PowAB(a, b - 1);
} 


System.Console.Write("Введите основание степени: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowAB(A, B));
*/