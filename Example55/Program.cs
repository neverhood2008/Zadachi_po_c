//Задача 55
//Поменять местами строки и столбцы
int getDataFromUser(string message)
{
   printInColor(message+"\n",ConsoleColor.Yellow);
   int data = int.Parse(Console.ReadLine()!);
    return data;
}
bool CheckCanRotate (int rows, int cols)
{
    return rows==cols;
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

int[,] rotateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = i; j < array.GetLength(1); j++)  
        { int temp=array[i,j];
        array[i,j]=array[j,i];
        array[j,i]=temp;
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
int rows=getDataFromUser("Введите число строк ");
int cols=getDataFromUser("Введите число столбцов ");
bool canContinue=CheckCanRotate(rows,cols);
if (canContinue)
{
  int[,] array =generate2DArray(rows,cols,0,50);
printArray(array);

int[,] rotatedArray = rotateMatrix(array);
printArray(rotatedArray);
  
}
else 
{
    printInColor($"для переворода нужна квадратная матрица",ConsoleColor.Red);
}
