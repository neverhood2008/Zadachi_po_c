//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double [] fillArray (int length,double start,double end)
{
    double [] array = new double [length];
    for (int i=0;i<length;i++)
    {
        array[i]=Math.Round(new Random().NextDouble()*(end-start)+start,1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
double diff (double [] array)
{
    double max=array[0];
    double min=array[0];
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]<min)
        {
           min=array[i];
        }
        if (array[i]>max)
        {
            max=array[i];
        }
    }
   double diffNumber=max-min;
    return diffNumber;
   }  

void printArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );  
        if (i  < array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine("]");
}
int length=getUserData("Введите количество элементов в массиве");
int start=getUserData("Введите минимальное число случайных чисел массива");
int end=getUserData("Введите максимальное число случайных чисел массива");
double [] array=fillArray(length,start,end);
printArray(array);
double diffMaxMin=Math.Round(diff(array),1);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diffMaxMin}");