// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.//
//7 -> 28
//4 -> 10
//8 -> 36

int Sum(int A)
{
    int sum = 0;
    for(int i = 1; i <= A; i += 1)
{
    sum += i;
}
return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от одного до {number} равна {sum}");

/*
int Composition(int N)
{
    int sum = 1;
    for(int i = 1; i <= N; i += 1)
{
    sum = sum * i;
}
return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Composition(number);
Console.WriteLine($"Сумма от одного до {number} равна {sum}");

Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int Counting(int number)
{
int count = 0;
while(number != 0)// == проверка на равенство, != проверка на неравенство
{
number/=10;
count++;
}
return count;
}
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // int number = Math.Abs(Convert.ToInt32(Console.ReadLine())) - модуль числа
int count = Counting(number);
System.Console.WriteLine($"Цифр в нашем числе {number} = {count}");

Второй вариант
System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
if(int.TryParse(str, out int number))
{
if(str[0] == '-') // str.Contains("-") // number < 0
{
Console.WriteLine($"Цифр в нашем числе {number} = {str.Length - 1}");
}
else
{
Console.WriteLine($"Цифр в нашем числе {number} = {str.Length}");
}
}
else
{
System.Console.WriteLine("Ошибка");
}
*/