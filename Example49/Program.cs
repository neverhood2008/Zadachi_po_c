//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int getUserData(string message)
{
    Console.Write(message);
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
            array[i,j]= new Random().Next(start,finish+1);
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


int [,] Change(int [,] array)
{
   for (int i = 0; i <array.GetLength(0) ; i++)
   {
    for (int j = 0; j <array.GetLength(1); j++)
    {
      if (i%2==0 && j%2==0)  
      {
        array[i,j]=(int)Math.Pow(array[i,j],2);
      }
    }
   }
   return array;
  
}
int colLenght=getUserData("Введите количество строк: ");
int rowLenght=getUserData("Введите количество столбцов: ");
int [,] array=AddArray(colLenght,rowLenght,0,10);
printArray(array);
Console.WriteLine();
int [,] arraySquare=Change(array);
printArray(arraySquare);