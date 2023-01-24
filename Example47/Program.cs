/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}

double [,] AddArray(int colLength, int rowLength, int start, int finish)
{
    double [,] array=new double [colLength,rowLength] ;
    const int divinder=10;
    for (int i=0;i<colLength;i++)
    {
         for (int j = 0; j < rowLength; j++)
         {
            array[i,j]= new Random().Next(start*divinder,(finish+1)*divinder)/(divinder+0.0);
         }
       
    }
    return array;
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
void printArray(double[,] array, int numberColor)
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

int n=getUserData("Введите количество строк: ");
int m=getUserData("Введите количество столбцов: ");
int numberColor= new Random().Next(1,16);
double [,] array=AddArray(n,m,0,100);
printArray(array,numberColor);
