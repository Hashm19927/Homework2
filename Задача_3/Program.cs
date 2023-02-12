/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int number;
Console.Write("1-понедельние\n2-вторник\n3-среда\n4-четверг\n5-пятница\n6-суббота\n7-воскресение\nвведите число: ");
int.TryParse(Console.ReadLine()!,out number);

if (number==1)
    Console.Write("Понедельник..работаем");
else if (number==2)
    Console.Write("Вторник..работаем");
else if (number==3)
    Console.Write("Среда..все еще работаем");
else if (number==4)
    Console.Write("Четверг..вот уже почти");
else if (number==5)
    Console.Write("Пятница..считай, что почти выходной");
else if (number==6)
    Console.Write("Суббота! Выходной");
else if (number==7)
    Console.Write("Воскресение! Выходной");
else if (number>7)
    Console.Write("В неделе 7 дней так-то");
else if (number<=0)
    Console.Write("Амм, нет, такой недели нет");