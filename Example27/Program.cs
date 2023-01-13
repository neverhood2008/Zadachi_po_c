//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
int getSumOfDigit (int number)
{
    int sum=0;
    int temp;
    while (number>0)
    {
        temp=number%10;
        number=number/10;
        sum+=temp;
    }
    return sum;
}
void showData (string messageStart,int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
    }
int number=getUserData("Введите число А ");
int sum=getSumOfDigit(number);
showData($"Сумма цифр в числе {number}  цифр = ", sum);