//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int getUserData(string message)
{
    Console.Write(message);
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
int [] InsertMassiv(int n)
{
    int [] array=new int [n] ;
    for (int i=0;i<n;i++)
    {
        array[i]=getUserData($"Введите {i}-элемент массива = ");
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
int countPositive(int [] array)
{
   
   int count=0;
   for (int i=0;i<array.Length;i++)
    {
        if (array[i]>=0)
        count+=1;
    }
    return count; 
}
int number=getUserData("Введите количество элементов: ");
int [] array=InsertMassiv(number);
printArray(array);
int count=countPositive(array);
Console.WriteLine($"Количество положительных элементов= {count}");