//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

int findElement(int [,] array, int row, int col)
{
    int element=array[0,0];
        for (int i=0;i<array.GetLength(0);i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            
            if (i==row && j==col)
            {element=array[i,j];
            }
         }
       
    }
    return element;
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

int n=getUserData("Введите количество строк: ");
int m=getUserData("Введите количество столбцов: ");
int numberColor= new Random().Next(1,16);
int [,] array=AddArray(n,m,0,100);
printArray(array,numberColor);
int row=getUserData("Введите номер строки,в которой находится элемент: ");
int col=getUserData("Введите номер столбца,в которой находится элемент: ");
if (row>n || col>m)
{
    Console.WriteLine($"Элемента с позицией [{row},{col}] не существует ");
}
else 
{
    int element=findElement(array,row,col);
    Console.WriteLine($" Элемент  [{row},{col}]= {element}");
}
