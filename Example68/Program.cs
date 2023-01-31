﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
bool checkBool(int m, int n)
{
    return (m >= 0 && n >= 0);
}
int Akkerman(int m, int n)
{
    if (m == 0)
    { return n + 1; }
    if (n == 0)
    { return Akkerman(m - 1, 1); }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
int userNumberA = getDataFromUser(" Введите число m=");
int userNumberB = getDataFromUser(" Введите число n=");
if (checkBool(userNumberA, userNumberB))
{
    int sum = Akkerman(userNumberA, userNumberB);
    printInColor("Функция Аккермана: " + sum, ConsoleColor.Green);
}
else printInColor("Введите неотрицательные числа", ConsoleColor.Green);