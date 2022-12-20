Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
int result=arg1;
if (arg2>result) result=arg2;
if (arg3>result) result=arg3;
return result;
}

int[] array={1,35,465,64,6,6,3,23,64};
int result=Max(
   Max(array[0],array[1],array[2]),
   Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);

int n=array.Length;
int index=0;
int find=64;
while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
        }
    index=index+1;

}
