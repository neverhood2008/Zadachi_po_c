//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//
//645 -> 5
//
//78 -> третьей цифры нет
//
//32679 -> 6


int razryadnost (int number)
{
    int count=1;
    if (number<0)  
    {number=-number;}
    
    int temp=number/10;
    while (temp>=1)
    {count=count+1;
    temp=temp/10;}
    return count;
}
Console.WriteLine("Введите число");
int number= int.Parse(Console.ReadLine()!);
Console.WriteLine("Разрядность числа");
int razryad = razryadnost(number);
Console.WriteLine(razryad);
int indexThird=razryad-2;
//int temp=1;
//for (int i=0;i<indexThird;i++)
//{temp=temp*10;}
//double third=(number%temp)/(temp/10);
int third=(number%(Convert.ToInt32(Math.Pow(10,indexThird))))/(Convert.ToInt32(Math.Pow(10,indexThird-1)));
if (third<0)
{third=-third;}
if (number<100 && number>-100)
{Console.WriteLine("Третьей цифры в числе нет");}
else {Console.WriteLine($"третья цифра={third}");}


