// Напишите программу,которая выводит случайное число из отрезка [10,99]
//и показывает наибольшую цифру
int GetNumberFromRange (int start, int end)
{
    int number = new Random().Next(start,end+1);
    return number;
}
int GetMaxDigit (int number)
{
    int digit1=number%10;
    int digit2=number/10;
    int max=0;
    if (digit1>digit2)
    {
        max=digit1;
    }
    else
    {
        max=digit2;
    }
    return max;

}

int randomNumber=GetNumberFromRange(10,99);
Console.WriteLine(randomNumber);
int maxDigit=GetMaxDigit(randomNumber);
Console.WriteLine($"Для числа {randomNumber} максимальная цифра является {maxDigit}");