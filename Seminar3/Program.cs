/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
Console.Write("Точка лежит в первой четверти");
}
else if (x < 0 && y > 0)
{
Console.Write("Точка лежит во второй четверти");
}
else if (x < 0 && y < 0)
{
Console.Write("Точка лежит в третьей четверти");
}
else if (x > 0 && y < 0)
{
Console.Write("Точка лежит в четвертой четверти");
}
else
{
Console.Write("Точка лежит на оси");
}

Задача №18 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
string[] quarters = {"x > 0; y > 0", 
"x < 0; y > 0",
"x < 0; y < 0",
"x > 0; y < 0"};
System.Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());
if(quater >= 1 && quater <= 4)
{
System.Console.WriteLine(quarters[quater - 1]);
}
else
{
System.Console.WriteLine("Неправильно номер четверти");
}

Задача №21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
double number = 5;
// double res = Math.Pow(number, 2); // возведение в степень
// System.Console.WriteLine(res);
double res = Math.Sqrt(number); // извлечение квадратного корня
res = Math.Round(res, 3); // округление
System.Console.WriteLine(res);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
double Distance2D(double x1, double y1, double x2, double y2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
return Math.Round(res, 2);
}
Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
double distance = Distance2D(x1, y1, x2, y2);
System.Console.WriteLine($"Расстояние между точками = {distance}");

Задача №22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++) 
{
Console.Write($"{Math.Pow(i, 2)} ");
}


*/


