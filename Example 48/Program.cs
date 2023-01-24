//Задача 48: Задайте двумерный массив. заполненный  a[i,j]=i+j
int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}

int [,] AddArray(int colLength, int rowLength, int start, int finish)
{
    int [,] array=new int [colLength,rowLength] ;
    
    for (int i=0;i<colLength;i++)
    {
         for (int j = 0; j < rowLength; j++)
         {
            array[i,j]= i+j;
         }
       
    }
    return array;
}


void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void printArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int n=getUserData("Введите количество строк: ");
int m=getUserData("Введите количество столбцов: ");
int [,] array=AddArray(n,m,0,10);
printArray(array);
