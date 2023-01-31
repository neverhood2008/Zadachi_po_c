/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int getDataFromUser(string message)
{
    printInColor(message, ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}
void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
string printRange(int n)
{
    if (n == 1)
    { return n + ""; }
    return n + "," + printRange(n - 1);
}
int userNumber = getDataFromUser(" Введите число n=");
string resultString = printRange(userNumber);
printInColor(resultString, ConsoleColor.Green);