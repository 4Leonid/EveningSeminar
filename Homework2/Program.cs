/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

int FindSecond(int num)
{
    int firstItaration = num / 10;
    int result = firstItaration % 10;

    return result;   
}

Console.Write($"Inter you number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The second number of {number} is: {FindSecond(number)}");

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


void FindThird(int num)
{
  if (num < 100) 
  {
    Console.WriteLine($"У цифры {num} нет треньей цифры");
   return;
  }
   
  if (num > 999)
    {
      num /= 10;
    }
    Console.WriteLine($"The third number of {num} is {num % 10}");   
}

Console.Write($"Inter you number: ");
int number = Convert.ToInt32(Console.ReadLine());

FindThird(number);
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/
void WeekDay(int num)
  { 
    if (num > 7) 
    {
      Console.WriteLine("Нет такого дня недели");
      return;
    }
    
    if (num == 6 || num == 7)
    {
      Console.WriteLine($"{num} день это выходной");
      return;
    } 

      Console.WriteLine($"{num}-Й день это будний день!");
  } 

Console.Write($"Inter you week day: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

WeekDay(weekDay);
