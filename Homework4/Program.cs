/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


int Degree(int numOne, int numTwo)
{
    int sum = 1;
    for(int i = 1; i <= numTwo; i += 1)
    {
    sum *= numOne;
    }
return sum;
}

Console.Write("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int result = Degree(numberOne, numberTwo);
Console.WriteLine($"{numberOne} в {numberTwo} степени равно {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

int SumOfNumber(int number)
{
    int sum = 0;
    while(number > 0) 
    {
        sum += number % 10;
        number /= 10;
    }
    
return sum;
}
Console.Write("Введитечисло: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumber(number);
Console.Write($"Сумма чисел в {number} равна {result}");
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
*/

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i += 1)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintNumbers(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i +=1)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}");
    Console.WriteLine("]");
}
int length = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(length, min, max);
PrintNumbers(array);