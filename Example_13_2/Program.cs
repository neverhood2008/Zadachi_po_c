//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//
//645 -> 5
//
//78 -> третьей цифры нет
//
//32679 -> 6


int Third (int number)
{
       
    int temp=number;
    while ((temp/10)>100) 
    {temp=temp/10;
    }
    int digit = temp%10;
    return digit;
}
Console.WriteLine("Введите число");
int number= int.Parse(Console.ReadLine()!);
int number2=number;
if (number<0)
{ number2=-number;}
if (number<100 && number>-100)
{Console.WriteLine("Третьей цифры в числе нет");}
else {int third2= Third(number2);
    Console.WriteLine($"третья цифра={third2}");}
