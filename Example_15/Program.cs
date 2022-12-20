// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//
//6 -> да
//7 -> да
//1 -> нет
void Day(int number)
{
    if (number==6 || number==7)
    {
        Console.WriteLine($"День, соответвующий числу {number}, является выходным");
    }
    else 
    {
      Console.WriteLine($"День, соответвующий числу {number}, не является выходным");
    }
}

void Name (int number)
{
string[] array= {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
string day=array[number-1];
Console.WriteLine($"День, соответвующий числу {number}, является {day}");
}




Console.WriteLine("Введите число,соответствующего дня недели");
int numberDay= int.Parse(Console.ReadLine()!);
if (numberDay>0 && numberDay<8)
{
    Day(numberDay);  
    Name(numberDay);
}
else 
{
    Console.WriteLine("Введите число в диапазоне от 1 до 7");   
}