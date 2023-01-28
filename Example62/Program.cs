/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int getDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

int[,] generate2DArray(int rowLength, int colLength)
{
    int[,] array = new int[rowLength, colLength];
    int number = 1;
    int k = 0; int l = 0;
    int m = rowLength - 1;
    int n = colLength - 1;
    int count=rowLength*colLength;
    while (number <= count)
    {
        for (int j = k; j <= n; j++)
        {
            array[l, j] = number;
            number = number + 1;

        }
        l = l + 1;
        for (int j = l; j <= m; j++)
        {
            array[j, n] = number;
            number = number + 1;

        }
        n = n - 1;
        for (int j = n; j >= k; j--)
        {
            array[m, j] = number;
            number = number + 1;

        }
        m = m - 1;
        for (int j = m; j >= l; j--)
        {
            array[j, k] = number;
            number = number + 1;

        }
        k = k + 1;

    }
    return array;

}


void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
}
void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.DarkCyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("________________________________________");
}
int rows = getDataFromUser("Введите число строк ");
int cols = getDataFromUser("Введите число столбцов  ");
int[,] array = generate2DArray(rows, cols);
printArray(array);
