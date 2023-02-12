/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

/*int number;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
//int number2=number/10;
if (number>999)
    number=(number/10)%10;
Console.Write(number);*/

/*Console.Write("Введите число: ");
string number = Console.ReadLine()!;

char thirdChar = number[2];
if (number[2]<0)
    Console.Write("3й цифры нет");
else
    Console.WriteLine(thirdChar);*/


int Prompt(string message)
{
    Console.Write(message);
    string value=Console.ReadLine()!;
    int result=Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while(number>999)
    {
        //number/=10;
        number=number/10;
    }
    return number%10;
}
bool ValidateNumber(int number)
{
    if (number<100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число: ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}