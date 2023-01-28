/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int getDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

int[,] generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }

    }
    return array;
}

(int, int) FindPosMinSumRow(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumRow[i] = sum;
    }
    int sumMin=sumRow[0];
    int posMin=0;
    for (int i =1; i<array.GetLength(0);i++)
    {
        if (sumRow[i]<sumMin)
        {
            sumMin=sumRow[i];
            posMin=i;
        }
    }
    return (posMin,sumMin);
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
int cols = getDataFromUser("Введите число столбцов ");
int[,] array = generate2DArray(rows, cols, 0, 10);
printArray(array);
(int,int) posSumMin=FindPosMinSumRow(array);
Console.WriteLine($"Минимальная сумма элементов строки = {posSumMin.Item2} находится в строке {posSumMin.Item1}");