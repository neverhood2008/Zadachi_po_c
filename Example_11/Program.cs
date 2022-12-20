//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

void Ostatok(int numberA)
{
    int ost1 = numberA % 7;
    int ost2 = numberA % 23;
    
    if (ost1 == 0 && ost2 == 0)
    {
        Console.WriteLine("Число одновременно кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Число одновременно не кратно 7 и 23"); 
    }
}



Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
Ostatok(number);



