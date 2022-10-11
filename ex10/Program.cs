// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//456 -> 5
// 782 -> 8
//918 -> 1

Console.WriteLine("enter a 3digits number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
     Console.WriteLine("you entered not a 3digits number");
else
{

    int firstDigit= number / 100;
    int twoDigit = number * 10 / 100;

    int twoNumber = twoDigit - firstDigit * 10;

    Console.Write($"Second numbe4r of entered number: {twoNumber}");
}


