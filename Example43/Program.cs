//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
double [] findXY(double k1,double b1, double k2, double b2)
{
    double [] array= new double [2];
    array[0]=Math.Round((b2-b1)/(k1-k2),1);
    array[1]=Math.Round(k1*array[0]+b1,1);
    return array;
}
int k1=getUserData("Введите k1 для уравнения y = k1 * x + b1 : ");
int b1=getUserData("Введите b1 для уравнения y = k1 * x + b1 : ");
int k2=getUserData("Введите k2 для уравнения y = k2 * x + b2 : ");
int b2=getUserData("Введите b2 для уравнения y = k2 * x + b2 : ");
if (k1==0 && k2==0)
{
   Console.Write($"Прямые не пересекаются "); 
}
else 
{if (k1==k2 && b1==b2)
{
    Console.Write("Бесконечное число решений "); 
}
else 
{double [] array=findXY(k1,b1,k2,b2);
Console.Write($"Прямые пересекаются в точке [{array[0]};{array[1]}]");}}