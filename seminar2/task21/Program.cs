//21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int x1=getUserValue("Введите x1: ");
int y1=getUserValue("Введите y1: ");
int x2=getUserValue("Введите x2: ");
int y2=getUserValue("Введите y2: ");

double sqrt1= Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
Console.WriteLine($" расстояние = {Math.Round(sqrt1,2)}");
