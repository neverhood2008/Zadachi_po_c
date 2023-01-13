// 28. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
//4->24

int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
int getMulrtiplyOfRange (int start, int end)
{
    int multy=1;
    for (int i=start;i<=end;i++)
    {
        multy=multy*i;
    }
    return multy;
}
void showData (string messageStart,int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
    }
int number=getUserData("Введите число N ");
int multy=getMulrtiplyOfRange(1,number);
showData($"Произведение чисел от 1 до {number} =", multy);