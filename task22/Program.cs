// 22 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел 
//от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void kvadrat(int n)
{
    for (int i = 1; i < n + 1; i = i + 1)
    {
        int temp = i * i;
        if (i<n)
        {Console.Write($"  {temp},");}
        else 
        {Console.Write($"  {temp}");}
    }
}
int n = getUserValue("Введите n: ");
kvadrat(n);