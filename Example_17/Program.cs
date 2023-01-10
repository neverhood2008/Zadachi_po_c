// напишите программу,которая принимает на вход координаты точки (x,y)
//причем x<>0 и y<>0 , и выдает номер четверти плоскости, в которой находится эта точка
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result=int.Parse(Console.ReadLine()!);
    return result;
}
int getQuarterNumber(int x, int y)
{
    int quarter=0;
    if (x>0 && y>0)
    {
        quarter=1;
    }
    else 
    if (x<0 && y>0)
    {
        quarter=2;
    }
     else  if (x<0 && y<0)
    {
        quarter=3;
    }
     else  if (x>0 && y<0)
    {
        quarter=4;
    }
    return quarter;
}
void showQuarter(int X, int Y)
{
if (X!=0 && Y!=0)
{
    int quarter=getQuarterNumber(X,Y);
    Console.WriteLine($" точка [{X},{Y}] находится в {quarter} четверти");
}
else
{
    Console.WriteLine($" точка [{X},{Y}] находится на оси координат");
}
}

int userX=getUserValue("Введите x");
int userY=getUserValue("Введите y");
showQuarter(userX,userY);
