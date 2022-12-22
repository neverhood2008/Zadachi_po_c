// Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void distance(int x1, int y1, int z1, int x2, int y2,int z2)
{
   double sqrt= Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),2); 
   Console.WriteLine($" Расстояние = {sqrt}");
}
int x1=getUserValue("Введите x1: ");
int y1=getUserValue("Введите y1: ");
int z1=getUserValue("Введите z1: ");
int x2=getUserValue("Введите x2: ");
int y2=getUserValue("Введите y2: ");
int z2=getUserValue("Введите z2: ");
distance(x1,y1,z1,x2,y2,z2);
