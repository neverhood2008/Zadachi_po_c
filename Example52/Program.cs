//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.Write(message);
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
            array[i,j]= new Random().Next(start,finish+1);
         }
       
    }
    return array;
}

double [] sredneeArifmetic(int [,] array)
{
    double [] arraySrednee = new double [array.GetLength(1)];
    int temp=0;
    for (int j=0;j<array.GetLength(1);j++)
    {
        temp=0;
         for (int i = 0; i< array.GetLength(0); i++)
        {
            temp+=array[i,j];
        }
        arraySrednee[j]=Math.Round(temp/(array.GetLength(0)+0.0),1);
    }
      return arraySrednee;   
    }
  


void printInColor(string data,int numberColor)
{
    switch (numberColor)
    {
        case 1:{Console.ForegroundColor = ConsoleColor.Black;break;}
        case 2:{Console.ForegroundColor = ConsoleColor.DarkBlue;break;}
        case 3:{Console.ForegroundColor = ConsoleColor.DarkGreen;break;}
        case 4:{Console.ForegroundColor = ConsoleColor.DarkCyan;break;}
        case 5:{Console.ForegroundColor = ConsoleColor.DarkRed;break;}
        case 6:{Console.ForegroundColor = ConsoleColor.DarkMagenta;break;}
        case 7:{Console.ForegroundColor = ConsoleColor.DarkYellow;break;}
        case 8:{Console.ForegroundColor = ConsoleColor.Gray;break;}
        case 9:{Console.ForegroundColor = ConsoleColor.DarkGray;break;}
        case 10:{Console.ForegroundColor = ConsoleColor.Blue;break;}
        case 11:{Console.ForegroundColor = ConsoleColor.Green;break;}
        case 12:{Console.ForegroundColor = ConsoleColor.Cyan;break;}
        case 13:{Console.ForegroundColor = ConsoleColor.Red;break;}
        case 14:{Console.ForegroundColor = ConsoleColor.Magenta;break;}
        case 15:{Console.ForegroundColor = ConsoleColor.Yellow;break;}
        

    }
   
    Console.Write(data);
    Console.ResetColor();
}
void printArray(int[,] array, int numberColor)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t",numberColor);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t",numberColor);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void printArrayDouble(double[] array, int numberColor)
{ 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("SRA"+"\t");
     for (int i = 0; i < array.Length; i++)
    {
       
            Console.Write(array[i] + "\t");
    }
        Console.WriteLine();
        Console.ResetColor();
    }


int n=getUserData("Введите количество строк: ");
int m=getUserData("Введите количество столбцов: ");
int numberColor= new Random().Next(1,16);
int [,] array=AddArray(n,m,0,10);
printArray(array,numberColor);
double [] arraySrednee=sredneeArifmetic(array);
printArrayDouble(arraySrednee,numberColor);