// Задача 5. Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
Console.Clear();
Console.WriteLine("Введите число ");
int number=int.Parse(Console.ReadLine()!);
int temp=-number;
while (temp<=number)
{
 Console.Write(temp+" "); 
 temp++;  
}
