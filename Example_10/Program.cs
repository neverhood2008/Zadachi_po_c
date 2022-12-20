// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
void  Ostatok(int numberA, int numberB)
{
    int ost = numberA%numberB;
    if (ost==0)
    {
        Console.WriteLine("Числа кратны");
    }
    else
    {
       Console.WriteLine($"Остаток  {ost}"); 
    }
}
Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
Ostatok(number1,number2);



