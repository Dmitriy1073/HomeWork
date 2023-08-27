// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

	void NaturalNumber(int number, int count)// Фуекция вывода чисел от N до 1
	{
	    if (count > number)
	    {
	        return;
	    }
	    else
	    {
	        NaturalNumber(number, count + 1);
	        Console.Write(count + ", ");
	    }
	}



void SumFromMToN(int m, int n)// вызов функции "сумма чисел от M до N"
{
    Console.WriteLine($"Сумма натуральных элементоа от {m} до {n} равна {SumMN(m - 1, n)}");
}



int SumMN(int m, int n)// функция сумма чисел от M до N
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}


void AkkermanFunction(int m, int n)// вызов функции Аккермана
	{
	    Console.WriteLine($" Функция Аккермана для чисел {m} и {n} = {Akkerman(m, n)}"); 
	}
	
	
int Akkerman(int m, int n)// функция Аккермана для чисел м и n
	{
	    if (m == 0)
	    {
	        return n + 1;
	    }
	    else if (n == 0 && m > 0)
	    {
	        return Akkerman(m - 1, 1);
	    }
	    else
	    {
	        return (Akkerman(m - 1, Akkerman(m, n - 1)));
	    }
	}


// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();	
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNumber(number, count);
Console.WriteLine();

	



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());
if(m1>0 && n1>0)
AkkermanFunction(m1,n1);
else Console.WriteLine("Введено отрицательное число");
	
	

	

