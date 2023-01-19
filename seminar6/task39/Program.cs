//Задача 39: Перевернуть массив


int [] generateArray (int length,int deviation)
{
   int [] array = new int [length];
    for (int i=0;i<length;i++)
    {
        array[i]=new Random().Next(-deviation,deviation);
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
int [] reverseArray(int [] array)
{
    int fulllength=array.Length;
    int length=array.Length/2;
     for (int i = 0; i < length; i++)
     {
        int buf=array[i];
        array[i]=array[fulllength-i-1];
        array[fulllength-i-1]=buf;
     }
     return array;

}
int [] array=generateArray(10,20);
printArray(array);
int [] reversed=reverseArray(array);
printArray(reversed);
