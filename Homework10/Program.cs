/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumberFrom(int number)
{
    if (number > 0)
    {
        Console.Write($"{number} ");
        PrintNumberFrom(number - 1);
    }
}

Console.Write("Input nuber: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumberFrom(number);

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int sum =0;
int FindSumOf(int numberM,int numberN)
{
    if(numberM==numberN+1)
    {
        return numberM;
    }
    FindSumOf(numberM+1,numberN);
    sum+=numberM;
    return sum;
}
System.Console.Write("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
FindSumOf(numberM,numberN);
System.Console.WriteLine(sum);


Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}
Console.WriteLine($"Функция Аккермана для M:{numberM} N: {numberN} = {AckermannFunction(numberM, numberN)}");