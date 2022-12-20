// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int GetNumberFromRange (int start, int end)
{
    int number = new Random().Next(start,end+1);
    return number;
}
int InsertSecondDigit (int number)
{
    int digit1=number/100;
    int digit3=number%10;
    int result=(number-(digit1*100+digit3))/10;
    return result;

}

int randomNumber=GetNumberFromRange(100,999);
int numberInsertSecond=InsertSecondDigit(randomNumber);
Console.WriteLine($"число {randomNumber} имеет вторую цифру: {numberInsertSecond}");