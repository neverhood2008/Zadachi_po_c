// Задача 1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом второго.
Console.Clear();
Console.WriteLine("Введите первое число ");
int number1=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int number2=int.Parse(Console.ReadLine()!);
if (number1==number2*number2)
{
 Console.WriteLine("Первое число является квадратом второго числа");  
}
else 
{
    Console.WriteLine("Первое число не является квадратом второго числа");  
}