//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;


}
int userNumber = getFromUserData("n=");
int sum = printRange(userNumber);
Console.WriteLine(sum);

int printRange(int n)
{

    if (n == 0)
    {
        return n;
    }
    return n % 10 + printRange(n / 10);
}
