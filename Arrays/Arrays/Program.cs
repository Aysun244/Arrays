//int num = 56473;
//int max = 0;
//int a;
//while(num>0)
//{
//    a = num % 10;
//    if(a>max)
//    {
//        max = a;
//    }
//    num /= 10;
//}
//{
//    Console.WriteLine(max);
//}


int num = 56;
int num1 = num;
while (num1 > 1)
{
    if (num1 % 2 != 0)
    {
        Console.WriteLine("Verilmis eded 2nin quvveti deyil");
        return;
    }
    num1 /= 2;
}

{
    Console.WriteLine("Verilmis eded 2nin quvvetidir");
}