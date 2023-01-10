// See https://aka.ms/new-console-template for more information
// void Method1()
// {
//     Console.WriteLine("Автор ");
// }
// Method1();
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст");
// void Method21(string msg, int count)
// {

//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21("Текст1",5);
//Method21(count:3, msg:"Текст2");
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year=Method3();
// Console.WriteLine(year);
// string Method4(int count, string text)
// {
//     int i=0;
//     string result=string.Empty;
//     while (i<count)
//     {
//         result=result+text;
//         i++;
//     }
//     return result;
// }
// string res=Method4(5,"z");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     int i=0;
//     string result=string.Empty;
//     while (i<count)
//     {
//         result=result+text;
//         i++;
//     }
//     return result;
// }
// string res=Method4(5,"z");
// Console.WriteLine(res);
for (int i=2;i<=10;i++)
{
    for (int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}
