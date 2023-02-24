/*
int num1 = 25;
int num2 = 40;
double num2 = 13.45;
string word = "nice";
char symbol = '4';
bool check = true;
Console.WriteLine($"my numbers are {num1} and {num2} and it is good!");

Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if(number1 == quad2)
    Console.WriteLine("Yes!");
else 
    Console.WriteLine("No!");


// Task 2.
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = - num;

while(current <= num)
{
    Console.Write(current + " ");
    current += 1;
}
Задача 1
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if(number1 > number2)
    Console.WriteLine($"{number1}");
else 
    Console.WriteLine($"{number2}");
    
// Задача 2
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
Console.WriteLine($"{number3}");
else
Console.WriteLine($"{max}");


// Задача 3
    Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) 
Console.WriteLine($"{number} is even number");
else
Console.WriteLine($"{number} is odd number");
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