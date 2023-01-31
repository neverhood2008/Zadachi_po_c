//Задача 69 возведения в степень

int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;


}
int userNumberA = getFromUserData("n=");
int userNumberB = getFromUserData("m=");
int sum = printRange(userNumberA, userNumberB);
Console.WriteLine(sum);

int printRange(int numA, int numB)
{

    if (numB == 0)
    {
        return 1;
    }
    return numA * printRange(numA, numB - 1);
}
