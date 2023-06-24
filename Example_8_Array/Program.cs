// int Max(int arg1, int arg2,int arg3)
// {
// int result=arg1;
// if(arg2>result) result=arg2;
// if(arg3>result) result=arg3;
// return result;
// }
int[] array = { 11, 21, 13, 41, 15, 61, 17, 81, 19 };
int n = array.Length;
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int z=0;
while (count<n)
{
    if (num==array[count])
    {
    Console.WriteLine("введенное число совпадает с " + (count) + " элементом массива");
    z=1;
    break;
    }

count = count + 1;
//
}
if (z==0)
{
    Console.WriteLine("совпадений не найдено");
}

//int max1=Max(a1,b1,c1);
// int max2=Max(a2,b2,c2);
// int max3=Max(a3,b3,c3);
// int max=Max(max1,max2, max3);

// второй вариант
// int max=Max(Max(a1,b1,c1),
//          Max(a2,b2,c2),
//             Max(a3,b3,c3));
// Console.WriteLine(max);