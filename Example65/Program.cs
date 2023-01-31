//Задача 63
// вывести натуральные числа от 1 до n
int getFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;


}

string getStrRange(int start, int finish)
{
    if (start == finish)
    {
        return start + "";

    }
    return start + "," + getStrRange(start + 1, finish);
}
int userNumberStart = getFromUserData("m=");
int userNumberFinish = getFromUserData("n=");
int start = Math.Min(userNumberStart,userNumberFinish);
int finish = Math.Max(userNumberStart,userNumberFinish);
string rage = getStrRange(start, finish);
Console.WriteLine(rage);


