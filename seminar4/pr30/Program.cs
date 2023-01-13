// Напишите программу, которая выводит массив из 8 элементов,
//заполненный 0 и 1 в случайном порядке
int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}

int [] FillArray(int length)
{
    int [] array = new int [length];
    for (int i=0;i<length;i++)
    {
        array[i]=new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write("\b\b");
    Console.Write("]");
}


int number=getUserData("Введите число элементов массива ");
int [] array=FillArray(number);
PrintArray(array);