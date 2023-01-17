//Задача 32: Задайте массив
//отр на полож и наоборот
int [] Fillarray (int length,int start,int end)
{
    int [] array = new int [length];
    for (int i=0;i<length;i++)
    {
        array[i]=new Random().Next(start,end+1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}

int[] invertarray (int [] arraytoinvert)
{
    for (int i=0;i<arraytoinvert.Length;i++)
    {
       arraytoinvert[i]=-arraytoinvert[i];
          }
    return arraytoinvert;
   }  

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );  
        if (i  < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int length=getUserData("длина массива");
int [] array=Fillarray(length,-9,9);
printArray(array);
int [] inv=invertarray(array);
printArray(array);