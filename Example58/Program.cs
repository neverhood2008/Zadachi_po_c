/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiplyArray(int[,] arrayA, int[,] arrayB)
{
    int[,] multypliedArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {

            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                multypliedArray[i, j] = multypliedArray[i, j] + arrayA[i, k] * arrayB[k, j];
            }

        }

    }

    return multypliedArray;
}
bool checkArrayMultiply(int[,] arrayA, int[,] arrayB)
{
    return arrayA.GetLength(1) == arrayB.GetLength(0);
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
int rowsA = getDataFromUser("Введите число строк первой матрицы ");
int colsA = getDataFromUser("Введите число столбцов первой матрицы ");
int[,] arrayA = generate2DArray(rowsA, colsA, 0, 10);
int rowsB = getDataFromUser("Введите число строк второй матрицы ");
int colsB = getDataFromUser("Введите число столбцов второй матрицы ");
int[,] arrayB = generate2DArray(rowsB, colsB, 0, 10);
printArray(arrayA);
printArray(arrayB);
bool checkArrayMulty = checkArrayMultiply(arrayA, arrayB);
if (checkArrayMulty)
{
    int[,] multypliedArray = MultiplyArray(arrayA, arrayB);
    printInColor("Результат умножения двух матриц", ConsoleColor.Red);
    Console.WriteLine();
    printArray(multypliedArray);
}
else
{
printInColor("Данные матрицы нельзя перемножить(количество столбцов первой матрицы должно быть равно количеству строк второй)", ConsoleColor.Red);
    Console.WriteLine();
}