/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
int sumNumber(int n, int m)
{
    if (n == m)
    { return m; }
    return n+sumNumber(n + 1,m);
}
int userNumberA = getDataFromUser(" Введите число n=");
int userNumberB = getDataFromUser(" Введите число m=");
int min=Math.Min(userNumberA,userNumberB);
int max=Math.Max(userNumberA,userNumberB);
int sum = sumNumber(min,max);
printInColor($"Сумма чисел промежутке [{userNumberA},{userNumberB}]={sum}", ConsoleColor.Green);