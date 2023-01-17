//Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество чётных 
//чисел в массиве.

int [] fillArray (int length,int start,int end)
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
int countChetnie (int [] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]%2==0)
        {
            count+=1;
        }
    }
    return count;
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
int length=getUserData("Введите количество элементов в массиве");
int [] array=fillArray(length,0,999);
printArray(array);
int count=countChetnie(array);
Console.WriteLine($"Количество четных чисел в массиве = {count}");