//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


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
int sumNechetniePosition (int [] array)
{
    int sum=0;
    for (int i=0;i<array.Length;i++)
    {
        if (i%2!=0)
        {
           sum+=array[i];
        }
    }
    return sum;
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
int start=getUserData("Введите минимальное число случайных чисел массива");
int end=getUserData("Введите максимальное число случайных чисел массива");
int [] array=fillArray(length,start,end);
printArray(array);
int sum=sumNechetniePosition(array);
Console.WriteLine($"Сумма элементов массива с нечетными позициями = {sum}");