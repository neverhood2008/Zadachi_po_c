//40 треугольник есть с такими сторонами или нет
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData=int.Parse(Console.ReadLine()!);
    return userData;
}
bool IsTriangleExist(int a, int b, int c)
{
    bool isExist=false;
    if (a<b+c && b<c+a && c<a+b)
    {isExist=true;}
    return isExist;
}
int a=getUserData("a=");
int b=getUserData("b=");
int c=getUserData("c=");
bool isExist=IsTriangleExist(a,b,c);
Console.WriteLine($"треугольник со сторонами ({a},{b},{c}) {((isExist)?"существует":"не сущесвует")}");
