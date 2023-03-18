/*
////
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


 int Prompt(string message)
 {
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
 }

int[] InputArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i += 1)
    {
        array[i] = Prompt($"Input {i + 1} number ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i += 1)
    {
        Console.Write($"{array[i]}");
    }
}

int CountPositiveNumbers(int[] array) 
{
    int count = 0;
    for(int i = 0; i < array.Length; i += 1)
    {
        if (array[i] > 0) 
        {
            count += 1; 
        }
    }
    return count;
}

int length = Prompt("Input qty numbers: ");
int[] array;
array = InputArray(length);
PrintArray(array);
int result = CountPositiveNumbers(array);
Console.WriteLine();
Console.WriteLine($"Qty of numbers > 0 is {result}");
/*
////
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int coef = 0;
int constant = 1;
int x_coord = 0;
int y_coord = 1;
int line1 = 1;
int line2 = 2;

 int Prompt(string message)
 {
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
 }

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coef] = Prompt($"Input coef for {numberOfLine} line ");
    lineData[constant] = Prompt($"Input constant for {numberOfLine} line ");
    return lineData;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coef] == lineData2[coef])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Lines are equal");
            return false;
        }
        else 
        {
            Console.WriteLine("Lines are parallel");
            return false;
        }
    }
    return true;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coef] - lineData1[coef]);
    coord[y_coord] = lineData1[constant] * coord[x_coord] + lineData1[constant];
    return coord;
}

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Point of cross y = {lineData1[coef]} * x + {lineData1[constant]} and y = {lineData2[coef]} * x + {lineData2[constant]} ");
    Console.WriteLine($" has coordinates ({coord[x_coord]}), {coord[y_coord]})");
}
*/

// Второе решение:
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");