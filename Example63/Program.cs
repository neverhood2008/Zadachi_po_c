//Задача 63
// вывести натуральные числа от 1 до n
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printRange(int n)
{
    if (n == 0)
    {  return;}
    Console.Write(n + ",");
    printRange(n - 1);
}
int userNumber = getFromUserData("n=");
printRange(userNumber);
