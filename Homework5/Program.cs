/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int sumIsEven = 0;
int sumIsNotEven = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        sumIsEven += array[i];
    }
    else
    {
        sumIsNotEven += array[i];
    }
}

System.Console.Write("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма четных значений равна {sumIsEven}, а сумма нечетных значений равна {sumIsNotEven}");


Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int sumIsNotEven = 0;

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        sumIsNotEven += array[i];
    }
}

System.Console.Write("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма  нечетных значений равна {sumIsNotEven}");


Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1
*/

double[] FillArrayWhithRandomDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        double num = rnd.Next(0, 100);
        arr[i] = num / 2;
    }
    return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWhithRandomDouble(size);


double min = array.Min();
double max = array.Max();

double result = max - min;

System.Console.Write("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Разница максимального числа {max}  и минимального {min}  равна {result} ");