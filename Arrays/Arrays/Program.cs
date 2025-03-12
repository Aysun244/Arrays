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


//int num = 56;
//int num1 = num;
//while (num1 > 1)
//{
//    if (num1 % 2 != 0)
//    {
//        Console.WriteLine("Verilmis eded 2nin quvveti deyil");
//        return;
//    }
//    num1 /= 2;
//}

//{
//    Console.WriteLine("Verilmis eded 2nin quvvetidir");
//}

int[] arr = { 22, 5, 7, 9, 23, 65 };
int min = arr[0];
int max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
        min = arr[i];
    if (arr[i] > max)
        max = arr[i];
}
int sum = min + max;
{
    Console.WriteLine(sum);
}



