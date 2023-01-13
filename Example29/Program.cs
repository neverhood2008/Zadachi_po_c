//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int getUserData(string message)
{
    Console.ForegroundColor=ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
int getMaxNumber (int bit)
{
    int numberBit=(int)(Math.Pow(10,bit));
    return numberBit;
}

int [] FillArray(int length, int max)
{
    int [] array = new int [length];
    for (int i=0;i<length;i++)
    {
        array[i]=new Random().Next(-max+1,max);
    }
    return array;
}
//1 способ
void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length;i++)
    {
        if (i<array.Length-1)
        {Console.Write(array[i]+", ");}
        else  {Console.Write(array[i]+"] ");}
    }
}   
//2 способ 
string StringArray(int [] array)
{
    string result=string.Empty;
    result+="[";
    for (int i=0;i<array.Length;i++)
    {
        if (i<array.Length-1)
        { result=result+$"{array[i]}"+", ";}
        else { result=result+$"{array[i]}"+"] ";}
    }
    return result;
}   

int number=getUserData("Введите число элементов массива ");
int bit=getUserData("Введите разрядность случайных чисел массива ");
int maxNumber=getMaxNumber(bit);
int [] array=FillArray(number, maxNumber);
PrintArray(array);
string stringmassiv=StringArray(array);
Console.WriteLine();
Console.WriteLine("Вывод массива:"+stringmassiv);