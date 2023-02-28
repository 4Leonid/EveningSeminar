// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;

    return hundreds * 10 + ones;
}

int randomNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randomNumber);

Console.WriteLine($" New number of {randomNumber} number is {newNumber}");

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

bool isDivided(int number, int firstDivider, int secondDivider)
{
return number % firstDivider == 0 && number % secondDivider == 0;
}

Console.Write($"Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isDivided(num, div1, div2));

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.






/*
int CutNumber( int num)
{
    int ferst = num / 10;
    int second = num % 10;
  if( ferst > second)
  {
    return ferst;
  }
  else
  {
     return second;
  }
   
}


 int randNumber= new Random().Next(10 ,99);
 int newNum = CutNumber(randNumber);

Console.WriteLine($"For {randNumber} max number is {CutNumber(randNumber)}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*

/*
решение от второго зала
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

 */

/*
int CutNumber( int num)
{
    int ferst = num / 10;
    int second = num % 10;
  if( ferst > second)
  {
    return ferst;
  }
  else
  {
     return second;
  }
   
}


 int randNumber= new Random().Next(10 ,99);
 int newNum = CutNumber(randNumber);

Console.WriteLine($"For {randNumber} max number is {CutNumber(randNumber)}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
*/