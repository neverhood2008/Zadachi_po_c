// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
//456->3
//78->2

int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
int getNumberOfDigit (int number)
{
    int numberOfDigit=0;
    while (number>0)
    {
        number=number/10;
        numberOfDigit++;
    }
    return numberOfDigit;
}
void showData (string messageStart,int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
    }
int number=getUserData("Введите число А ");
int numberOfDigit=getNumberOfDigit(number);
showData($"В числе {number}  цифр : ", numberOfDigit);