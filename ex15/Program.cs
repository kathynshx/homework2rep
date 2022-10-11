// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.Write("enter a number rappresenting a day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num<=5)
{
    Console.Write($"{num}-> no");
}
else if (num==6 || num ==7)
{
    Console.Write($"{num} -> yes");
}
else if (num>=8)
{
    Console.WriteLine("theres no such day of the week");
}