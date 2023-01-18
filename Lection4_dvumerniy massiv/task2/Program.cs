double factorial (int n)
{
    if (n==1) return 1;
    else return n*factorial(n-1);

}
for (int i=1;i<40; i++)
{
    Console.WriteLine($"{i}! = {factorial(i)}");
}
int fibonacci (int n)
{
    if (n==1 || n==2) return 1;
    else return fibonacci(n-2)+fibonacci(n-1);

}
for (int i=1;i<50; i++)
{
    Console.WriteLine($"f({i}) = {fibonacci(i)}");
}
