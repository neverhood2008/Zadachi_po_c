//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

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
int FindNumber(int [] array, int number)
{
    int result=-1;
 for (int i=0;i<array.Length;i++)
    {
        if (array[i]==number)
        {result= i;
        break;}
    }
    return result;
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

int number=getUserData("Введите количество элементов массива");
int [] array=Fillarray(number,-100,100);
printArray(array);
int findnumber=getUserData("Введите искомое число");

int result=FindNumber(array,findnumber);
if (result==-1)
{
    Console.WriteLine("Данного числа нет");
}
else { Console.WriteLine($"Число {findnumber} есть в массива по индексу {result}");}