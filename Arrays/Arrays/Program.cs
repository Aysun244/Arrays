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

//int[] arr = { 22, 5, 7, 9, 23, 65 };
//int min = arr[0];
//int max = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//        min = arr[i];
//    if (arr[i] > max)
//        max = arr[i];
//}
//int sum = min + max;
//{
//    Console.WriteLine(sum);
//}

//int[] arr = { 1, 3, 4, 6, 87, 23, 12 };
//int result = 0;
//for (int i=0;i<arr.Length;i++)
//{
//    if (arr[i] % 2 == 1 && arr[i] % 3 == 0)
//        result++;
//}
//{
//    Console.WriteLine("Say:"+result);
//}

int[] arr = { 2, 5, 8, 4, 56, 1, };
int result = 0;
for (int i = 0; i < arr.Length; i++)
{
    int num = arr[i];
    if (num < 2)
        continue;
    for (int m = 2; m * m <= num; m++)
    {
        if (num % m == 0)
        {

            result++;
            break;
        }
    }
}
    {
    Console.WriteLine(result);
    }



