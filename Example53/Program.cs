//Задача 53
//Поменять местами 1 и посл строку



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

int[,] swapRows(int[,] array, int row1, int rows2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp=array[row1,i];
        array[row1,i]=array[rows2,i];
        array[rows2,i]=temp;

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

int[,] array =generate2DArray(10,7, -5, 10);
printArray(array);

int[,] swappedArray = swapRows(array,0,array.GetLength(0)-1);
printArray(swappedArray);
