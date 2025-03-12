int num = 56473;
int max = 0;
int a;
while(num>0)
{
    a = num % 10;
    if(a>max)
    {
        max = a;
    }
    num /= 10;
}
{
    Console.WriteLine(max);
}
