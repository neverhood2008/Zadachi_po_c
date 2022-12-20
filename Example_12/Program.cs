//16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет


void Kvadrat(int numberA,int numberB)
{
   
    
    if (numberA == numberB*numberB || numberB == numberA*numberA)
    {
        Console.WriteLine(" число является квадратом второго");
    }
    else
    {
        Console.WriteLine("число не является квадратом второго"); 
    }
}



Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
Kvadrat(number1,number2);

