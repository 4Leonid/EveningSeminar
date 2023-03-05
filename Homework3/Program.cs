/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void IsPolindrom(int number)
{
    bool firstCheck = number / 10000 == number % 10;
    bool secondCheck = number / 1000 % 10 == (number % 100) / 10;
    if (firstCheck == secondCheck)
    Console.WriteLine($"{number} is polindrom");   
    else
    Console.WriteLine($"{number} is not polindrom"); 
}

IsPolindrom(number);
*/


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void IsPolindrom(int number)
{
    string num = Convert.ToString(number);
    int length = num.Length;
    if (length < 5 || length > 5)
    {
        Console.WriteLine("Введите 5 значное число, это число не подходит");
        return;
    }
    if (num[0] == num[length - 1] && num[1] == num[length - 2])
    Console.WriteLine($"{number} is polindrom");   
    else
    Console.WriteLine($"{number} is not polindrom"); 
}

IsPolindrom(number);
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(result, 2);
}

Console.Write("Введите координату по X для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату по Y для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату по Z для первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату по X для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между точками = {distance}");
*/



/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i += 1) 
{
Console.Write($"{Math.Pow(i, 3)} ");
}
*/