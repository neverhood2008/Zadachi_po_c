//Задача 31: Задайте массив из 12 элементов,заполненные случайнм образом в диапазоне [-9,9].
//найти сумму отр и полож чисел
int [] Fillarray (int length,int start,int end)
{
    int [] array = new int [length];
    for (int i=0;i<length;i++)
    {
        array[i]=new Random().Next(start,end+1);
    }
    return array;
}
// int getUserData(string message)
// {
//     Console.WriteLine(message);
//     int userData=int.Parse(Console.ReadLine()!);
//     return userData;
// }
// int getSumpositive(int [] array)
// {
//     int sum=0;
//  for (int i=0;i<array.Length;i++)
//     {
//         if (array[i]>0)
//         {sum+=array[i];
//         }
//     }
//     return sum;
//    }  

//    int getSumnegative(int [] array)
// {
//     int sum=0;
//  for (int i=0;i<array.Length;i++)
//     {
//         if (array[i]<0)
//         {sum+=array[i];
//         }
//     }
//     return sum;
//    }  

int getSumponeg(int [] array,int flag=1)
{
    int sum=0;
 for (int i=0;i<array.Length;i++)
    {
        if (array[i]*flag>0)
        {sum+=array[i];
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
int [] array=Fillarray(12,-9,9);
printArray(array);
//int sumpos=getSumpositive(array);
//int sumneg=getSumnegative(array);
int sumpos=getSumponeg(array,1);
int sumneg=getSumponeg(array,-1);

Console.WriteLine($"сумма позит чисел = {sumpos}");
Console.WriteLine($"сумма негат чисел = {sumneg}");
