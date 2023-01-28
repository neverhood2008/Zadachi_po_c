/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
using System.Collections.Generic;
int getDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}
bool checkArray(int x, int y, int z)
{
    int count = x*y*z;
    return count <= 90;
}

int[,,] generate3DArray(int row, int col, int plane)
{
    List<int> listNumber = new List<int>();
    int[,,] array = new int[row, col, plane];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < plane; k++)
            {
                int tempRandom = new Random().Next(10, 100);
                while (listNumber.Contains(tempRandom) == true)
                {
                    tempRandom = new Random().Next(10, 100);
                }
                listNumber.Add(tempRandom);
                array[i, j, k] = tempRandom;

            }
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void printArray(int[,,] array)
{

    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            { Console.Write(array[i, j, k] + $" ({i},{j},{k})" + "\t"); }
            Console.WriteLine();
        }

    }
    Console.WriteLine("________________________________________");
}
int row = getDataFromUser("Введите число x ");
int col = getDataFromUser("Введите число y ");
int plane = getDataFromUser("Введите число z ");
bool checkArrayBool=checkArray(row,col,plane);
if (checkArrayBool)
{
int[,,] array = generate3DArray(row, col, plane);
printArray(array);
}
else 
{
    Console.WriteLine("Невозможно заполнить матрицу неповторяющими случайными двузначными числами");
}
