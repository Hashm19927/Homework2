/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int number;
Console.Write("Введите трехзначное число: ");
int.TryParse(Console.ReadLine()!, out number);
int number2=number/10%10;
if (number<100)
    Console.Write("Нужно трехзначное число!");
else if (number>1000)
    Console.Write("Нужно трехзначное число!");
else
    Console.Write($"{number2}");
