//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


int[] Fillarray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int[] newarray(int[] array)
{
    int newlength = (int)Math.Ceiling(array.Length / 2.0);
    int[] arr = new int[newlength];
    for (int i = 0; i < newlength; i++)
    {
        if (i < newlength - 1 || array.Length%2==0)
        {
            arr[i] = array[i] * array[array.Length - i-1];
        }
        else
        {
            arr[i] = array[i];
        }
    }
    return arr;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = getUserData("Введите количество элементов массива");
int[] array = Fillarray(number, -10, 10);
printArray(array);
int [] array2=newarray(array);
printArray(array2);

 int newlength1 = (int)Math.Ceiling(7.0/2.0);
 int newlength2 = (int)Math.Ceiling(7.0/2);
  int newlength3 = (int)Math.Ceiling(6.0/2.0);
 int newlength4 = (int)Math.Ceiling(6.0/2);
 Console.WriteLine($"7 2.0 = {newlength1}");
 Console.WriteLine($"7 2 =  {newlength2}");
 Console.WriteLine($"6 2.0 =  {newlength3}");
 Console.WriteLine($"6 2 =  {newlength4}");
