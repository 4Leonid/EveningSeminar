
/*
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] FillArrayWhithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);

int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive+= array[i];
    }
    else
    {
        sumNegative+= array[i];
    }
}

System.Console.Write("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine($"Сумма положительных значений равна {sumPositive}, а сумма отрицательных значений равна {sumNegative}");
*/
int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i+=1)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

Console.Write("Input length array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

int sumPositime = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i+=1)
{
if(array[i] > 0)
{
    sumPositime+= array[i];
} else 
{
    sumNegative += array[i];
}
}

Console.Write("Your random array: ");
Console.WriteLine($"[{sting.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных значений равна {sumPositive}, а сумма отрицательных значений равна {sumNegative}");

/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] FillArrayWithRandomNumbers(int size){
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<arr.Length;i++){
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}
Console.Write("Input array size "); 
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(size);
Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
for(int i = 0; i < array.Length; i++){
    array[i] = array[i]*(-1);
}
Console.Write("New array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");


Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да


int [] FillArrayWithRandomNumbers(int size){
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<arr.Length;i++){
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}
Console.Write("Input array size "); 
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(size);

Console.Write("Input serching number ");
int search = Convert.ToInt32(Console.ReadLine());

Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

string result = "No";

for(int i=0; i<array.Length; i++){
    if(array[i] == search){
        result = "yes";
    }
}

Console.WriteLine(result);
int [] FillArrayWithRandomNumbers(int size){
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<arr.Length;i++){
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}
Console.Write("Input array size "); 
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(size);

Console.Write("Input serching number ");
int search = Convert.ToInt32(Console.ReadLine());

Console.Write("Array: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

//string result = "No";

for(int i=0; i<array.Length; i++){
    if(array[i] == search){
            Console.WriteLine("yes");
            return;
    }else{
        Console.WriteLine("No");
    }
}
*/