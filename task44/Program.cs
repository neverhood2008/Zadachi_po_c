﻿//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
string Fibonachi (int number)
{
    int n1=0;
    int n2=1;
    string result=$"{n1},{n2}";
    if (number==1)
    {result=$"{n1}";}
    if (number==2)
    {result=$"{n1},{n2}";}
else {
    for (int i=2;i<number;i++)
    {
        int n=n1+n2;
        result=result+","+n;
        n1=n2;
        n2=n;
    }}
    return result;
}
int number=getUserData("n");
string result=Fibonachi(number);
Console.WriteLine(result);
