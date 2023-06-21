// // ******Программа принимает на входе число N а на  выходе выдает целые числа
// // ******в диапазоне от - N до +N
// Console.WriteLine("Введите целое число");

// int N = Convert.ToInt32(Console.ReadLine());
// if(N>0)
// {
// for (int i = -N; i < N+1; i++)
// {
//     Console.Write(i);
//     Console.Write(",");
// }
// Console.WriteLine("");
// }
// else
// {
// for (int i = N; i < -(N-1); i++)
// {
//     Console.Write(i);
//     Console.Write(",");
// }
// Console.WriteLine("");
// }
// Console.WriteLine("The end");
// 
//****** Программа принимает техзначное число и выдает его последнюю цифру

// Console.WriteLine("Введите целое трехзначное число");

// int Num = Convert.ToInt32(Console.ReadLine());
// if (Num>99 & Num<1000)
// {
//     double ost=Num%10;
// Console.Write("Последняя цифра - ");
// Console.WriteLine(ost);
// }
// else 
// Console.WriteLine("Число вне указанного диапазона");

//******* при вводе числа любой разрядности выдается третья справа цифра
// Console.WriteLine("Введите целое число");

// int Num = Convert.ToInt32(Console.ReadLine());
//    double ost=Num%1000/100;
// Console.Write("Третья справа цифра - ");
// Console.WriteLine(ost);

//****** при вводе числа любой разрядности выдается третья справа цифра
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