// ***Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.WriteLine("Введите число 1");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int b = Convert.ToInt32(Console.ReadLine());
// if(a>b)
// {
//     Console.WriteLine("Наибольшее число="+a);
// }
// else if (b>a)
// {
//     Console.WriteLine("Наибольшее число="+b);
// }
// else
// Console.WriteLine("числа равны");

//***Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите число 1");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3");
// int c = Convert.ToInt32(Console.ReadLine());
// int max=a;
// if (b>max)
// {
//     max=b;
// }
// if (c>max)
// {
//     max=c;
// }
// Console.WriteLine("Наибольшее число ="+ max);

//***Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num%2==0)
// {
//     ("Число - "+ num+ ", четное");
// }
// else 
// Console.WriteLine("Число - "+ num+ ", нечетное");

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= num)
// {
//     if (count % 2 == 0)
//     {
//         Console.Write(count+",");
//     }
//     count++;
// }
// Console.WriteLine();
//Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
//которая принимает на вход целое число любой разрядности и на выходе 
//показывает вторую цифру слева этого числа или говорит, что такой цифры нет. 
//Через строку решать нельзя.
Console.WriteLine("Введите целое число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num>=10)
{
while (Num>=99)
{
    Num=Num/10;
}
Console.WriteLine(Num%10);
}
else
Console.WriteLine ("Цифры нет, слишком мало разрядов");