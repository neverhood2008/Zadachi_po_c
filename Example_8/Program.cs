 //8. Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число ");
int number=int.Parse(Console.ReadLine()!);
int temp=1;
while (temp<=number)
    {
        if (temp%2==0)
        Console.Write(temp+" ");
    temp=temp+1;
    }
