//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// int getUserData(string message)
// {
//     Console.WriteLine(message);
//     int userData=int.Parse(Console.ReadLine()!);
//     return userData;
// }
// (int,int) findXY(int a, int b)
// {
//     int x=a;
//     int y=b;
//     return(x,y);
// }
// (int,int) xy=findXY(1,5);

// Console.WriteLine(xy);
double [] generateArray (int length,double a, double b)
{
   double [] array = new double [length];
    for (int i=0;i<length;i++)
    {
        array[i]=new Random().NextDouble()* new Random().Next(a*100,b*100)
            }
    return array;
}

void printArray(int [] array)
{
    Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );  
        if (i  < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
     Console.ForegroundColor=ConsoleColor.DarkGreen;
    Console.WriteLine("]");
    Console.ResetColor();
}

int [] array=generateArray(20,-10.6, 30.0);
printArray(array);



