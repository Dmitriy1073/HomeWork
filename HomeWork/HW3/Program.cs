//****Задача 19
//****Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Method (double num) // преобразование числа в строку и проверка на палиндром
{
    string s_num=Convert.ToString(num);
Console.WriteLine("Введено число "+s_num);
    int lenght_num=s_num.Length;
    int count=0;
    int rezult=0;


    for(count=0; count<lenght_num/2; count++)
    {
        char B_symb=s_num[count];
        //Console.WriteLine(B_symb);
        char E_symb=s_num[(lenght_num-count-1)]; 
        //Console.WriteLine(E_symb);
        if(B_symb==E_symb)
        {
            Console.WriteLine(B_symb+" Похоже на "+ E_symb);
        }
        else rezult=rezult+1; 
    }
    if (rezult==0) Console.WriteLine("Это палиндром");
    else Console.WriteLine("Это не палиндром");
   
}

// Console.WriteLine("Введите N-значное число");
// double number = double.Parse(Console.ReadLine()!);

// Method(number);


// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите основание степени");
int A = Convert.ToInt32(Console.ReadLine()); //double A
Console.WriteLine("Введите показатель степени");
int B = Convert.ToInt32(Console.ReadLine()); //double B
        //double Rez = Math.Pow(A,B);
        //Console.WriteLine($"число {A} в степени {B} = {Rez}");
        stepen(A,B);

 void stepen(int A, int B) // Функция возведения числа А в степень В
        {
         int rez1=1;
         for(int i=1; i<=B; i++)
         {
             rez1=rez1*A;
         }
         Console.WriteLine($"число {A} в степени {B} = {rez1}");
        }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 

// Console.Clear();
        Console.WriteLine("Введите целое число");
        int number = Convert.ToInt32(Console.ReadLine());
        Sum_num(number);
        
 void Sum_num(int Num)// функция вычисления суммы чисел во введенном числе
 {       
        int sum=0;
        while (Num>10)
        {
        int ost= Num%10;
        Num=Num/10;
        sum=sum+ost;
        }
        sum=sum+Num;
        Console.WriteLine($"Сумма чисел в числе={sum}");
 }
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

        void FillArayNum(int[] array)// функция заполнения массива вручную
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        void PrintArrayForm(int[] array)// функция форматированной печати массива
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write($"{array[array.Length - 1]} ]");
            Console.WriteLine();

        }



        // тело программы
        //Console.Clear();
        Console.WriteLine("Введите размерность массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        FillArayNum(array);
        PrintArrayForm(array);


// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

void Score_num (double num) // преобразование числа в строку и вычисление кол-ва цифер в числе
{
    string s_num=Convert.ToString(num);
    Console.WriteLine("Введено число "+s_num);
    int lenght_num=s_num.Length;
    int count=0;
    int rezult=0;
    char ch = ',';
    for(count=0; count<lenght_num; count++)
    {
        char B_symb=s_num[count];
        //Console.WriteLine(B_symb);
        
        if(B_symb==ch)
        {
            rezult=rezult+0;
        }
        else rezult=rezult+1; 
    }
    Console.WriteLine($"Количество цифр в числе = {rezult}");
}





Console.WriteLine("Введите положительное число");
double number1 = double.Parse(Console.ReadLine()!);
if(number1>0) Score_num(number1);
else Console.WriteLine("Incorrect number");



