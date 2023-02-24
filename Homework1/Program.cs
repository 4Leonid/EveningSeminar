// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if(number1 > number2)
else 
    Console.WriteLine($"Max number is {number2} and min is {number1}");
   
// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(number1 > number2)
    max = number1;
    else 
    max = number2;
if (number3 > max)
Console.WriteLine($"Max number is {number3}");
else
Console.WriteLine($"Max number is{max}");
 
// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
    Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) 
Console.WriteLine($"{number} is even number");
else
Console.WriteLine($"{number} is not even number");
*/

// Задача 4
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if (current % 2 == 0)
    Console.Write(current + " ");
    current += 1;
}
