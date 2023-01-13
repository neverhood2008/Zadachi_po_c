//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
bool NatutalNumber(int numberB)
{
    bool natural=true;
    if (numberB <= 0) natural = false;
    return natural;
}
int getDegree(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 2; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int numberA = getUserData("Введите число A");
int numberB = getUserData("Введите степень B, в которую нужно возвести число A");
bool naturalDig = NatutalNumber(numberB);
if (naturalDig == true)
{
    int result = getDegree(numberA, numberB);
    showData($"{numberA}^{numberB}=", result);
}
else
{
    Console.WriteLine("Введите натуральное число степени (число B>0)");
}

