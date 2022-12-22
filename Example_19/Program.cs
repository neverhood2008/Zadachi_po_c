//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int razryadnost(int n)
{
    int count = 1;
    while (n / 10 > 0)
    {
        count = count + 1;
        n = n / 10;
    }
    return count;
}

void findPalindrom(int n)
{
    bool palindrom = true;
    int temp = n;
    int indexmax = razryadnost(n);
    for (int i = 1; i < indexmax + 1; i = i + 2)
    {
        int a = temp % 10;
        int b = temp / (int)(Math.Pow(10, indexmax - i));
        if (a != b)
        {
            palindrom = false;
            break;
        }
        temp = temp - b * (int)(Math.Pow(10, indexmax - i));
        temp = temp / 10;
    }
    if (palindrom == true)
    {
        Console.Write($" Число {n} является палиндромом");
    }
    else
    {
        Console.Write($" Число {n} не является палиндромом");
    }
}
int n = getUserValue("Введите n: ");
findPalindrom(n);