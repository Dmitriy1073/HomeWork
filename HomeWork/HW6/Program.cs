// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//-----------------------------------------------------------------------------------------------------
void FindNum(int[] array, int Num) // функция определения является ли введенное число элементом массива
{
    int f = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num)
        {
            f = f + 1;
            Console.WriteLine($"Искомое число является элементом {i} массива");

        }
        else f = f + 0;
    }
    if (f > 0) Console.WriteLine($"Искомое число является элементом массива");
    else Console.WriteLine("Искомое число не найдено");
}

//-----------------------------------------------------------------------------------------------------
void FillArray(int[] array, int leftBord, int rightBord)// функция заполнения массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftBord, rightBord);
    }
}

//-----------------------------------------------------------------------------------------------------
void PrintArray(int[] array)// функция печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//-----------------------------------------------------------------------------------------------------
void Reverse(int[] array) // функция замены отр. элементов массива на положительные
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) array[i] = -array[i];
        else array[i] = array[i];

    }
}

//-----------------------------------------------------------------------------------------------------
void FindNum1(int[] array, int Num) //  функция нахождения введенного числа в масиве (входит или нет)
{
    int f = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num)
        {
            f = f + 1;
            Console.WriteLine($"Искомое число является элементом {i} массива");

        }
        else f = f + 0;
    }
    if (f > 0) Console.WriteLine($"Искомое число является элементом массива");
    else Console.WriteLine("Искомое число не найдено");
}

//-----------------------------------------------------------------------------------------------------  
void FillArayNum(int[] array)// функция заполнения массива вручную
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

//-----------------------------------------------------------------------------------------------------    
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

//----------------------------------------------------------------------------------------------------- 
void FindNumDiapason(int[] array, int FindBordLeft, int FindBordRight) //нахождение числа элементов массива лежащих в заданном диапазоне
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < (FindBordRight + 1) && array[i] > FindBordLeft - 1) count = count + 1;
        else count = count + 0;
    }

    if (count > 0) Console.WriteLine($"{count} элементов массива входит в диапазон от {FindBordRight} до {FindBordLeft}");
    else Console.WriteLine("Элементы массива не входят в диапазон");
}


void SummChet(int[] array)  // функция нахождения суммы четных элементов массива
{
    int Sum = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Sum = Sum + array[i];
            count = count + 1;
        }
        else Sum = Sum + 0;
    }
    Console.WriteLine($"Всего в массиве {count} четных элементов");
    Console.WriteLine($"Сумма четных элементов массива =  {Sum}");
}


void SummNeChet(int[] array)  // функция нахождения суммы элементов массива c нечетным номером  
{
    int Sum = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            Sum = Sum + 0;
        }
        else
        {
            Sum = Sum + array[i];
            count = count + 1;
        }
    }
    //Console.WriteLine($"Всего в массиве {count} четных элементов");
    Console.WriteLine($"Сумма  элементов массива c нечетным номером = {Sum}");
}

int MaxArray(int[] array) //функция нахождения максимального элемента массива
{
    int MaxNum = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxNum)
        {
            MaxNum = array[i];
            count = i;
        }

    }
    Console.WriteLine($"Максимальный элемент массива [{count}] cо значением = {MaxNum}");
    return MaxNum; //Console.WriteLine($"Всего в массиве {count} четных элементов");

}

int MinArray(int[] array) //функция нaхождения минимального элемента массива
{
    int MinNum = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < MinNum)
        {
            MinNum = array[i];
            count = i;
        }

    }
    Console.WriteLine($"Минимальный элемент массива [{count}] cо значением = {MinNum}");
    return MinNum; //Console.WriteLine($"Всего в массиве {count} четных элементов");

}

int NumPozitiv(int[] array) //Функция нахождения числа положительных элементов массива 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;
    }
    return count;
}

void CrossLine(double k1, double b1, double k2, double b2) // Функция нахождения точек пересечения прямых заданных уравненеием
{
    if ((k1 - k2) == 0) Console.WriteLine("Прямые не имеют точек пересечения");
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых ({x}, {y})");
}


void Fill_Fibbonacci(int[] array)// функция заполнения массива числами Фибоначчи
        {
            array[0]=0;
            array[1]=1;
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i-1]+array[i-2];
            }
        }




void NegaFibonacci(int[] array_n, int[] array)// функция заполнения массива числами НегаФибоначчи
        {
            array_n[0]=0;
            array_n[1]=1;
            for (int i = 2; i < array_n.Length; i++)
            {
                array_n[i]= array[i]*Convert.ToInt32(Math.Pow(-1,i+1));
            }
        }

void Join_Fibonacci(int[] array_Join,int[] array, int[] array_n,int n)
{
    for(int i=0;i< array_Join.Length;i++)
    if (i<n)
    {
        array_Join[i]=array_n[array_n.Length-1-i];
    }
    else array_Join[i]=array[i-(n-1)];
}



// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// тело программы 
// пока закоментим 
// Console.WriteLine("Введите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array1 = new int[n];
// FillArayNum(array1);
// PrintArrayForm(array1);
// int Poz = NumPozitiv(array1);
// Console.WriteLine($"Количество положительных элементов введенного массива = {Poz}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//тело программы 
//пока закоментим
// Console.WriteLine("Для заданной функции y = k1 * x + b1 ");
// Console.Write("Введите К1-  ");
// double K1=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите B1-  ");
// double B1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Для заданной функции y = k2 * x + b2 ");
// Console.Write("Введите К2-  ");
// double K2=Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите B2-  ");
// double B2=Convert.ToDouble(Console.ReadLine());
// CrossLine(K1,B1,K2,B2);


// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
Console.Clear();
Console.WriteLine("Введите количество чисел последовательности Фибоначчи");
int n=Convert.ToInt32(Console.ReadLine());
int [] array=new int[n];
int [] array_n=new int[n];
int [] array_Join=new int[(n*2)-1];
Fill_Fibbonacci(array);
Console.WriteLine("Последовательность Фибоначчи");
PrintArrayForm(array);
NegaFibonacci(array_n,array);
Console.WriteLine("Последовательность НегаФибоначчи");
PrintArrayForm(array_n);
Join_Fibonacci(array_Join, array,array_n,n);
Console.WriteLine("Общий массив последовательности Фибоначчи/НегаФибоначчи");
PrintArrayForm(array_Join);

//задача 40 - HARD необязательная. На вход программы подаются три 
//целых положительных числа. Определить , является ли это сторонами 
//треугольника. Если да, то вывести всю информацию по нему - площадь, 
//периметр, значения углов треугольника в градусах, является ли он 
//прямоугольным, равнобедренным, равносторонним.
Console.WriteLine("Введите сторону А треугольника");
double A=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону B треугольника");
double B=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сторону C треугольника");
double C=Convert.ToDouble(Console.ReadLine());
// решение при помощи функции (см.ниже)
bool flag=Triangle(A,B,C);
if (flag=true ) Stat_Triangle(A,B,C);
else Console.WriteLine("Треугольника c такими сторонами АВС не существует");



bool Triangle(double a,double b, double c )// проверяет возможность существования треугольника с заданными сторонами
{
    bool flag=false;
    if(a+b>c&&a+c>b&&b+c>a) flag=true;
    return flag;
}


void Stat_Triangle(double a,double b, double c)// функция выдает сведения по треугольнику (Усложнение)
{
string Harakter=""; 
double Perimetr=a+b+c;
double X=(c*c+b*b-a*a)/(2*c);
double High=Math.Round(Math.Sqrt(b*b-X*X),3);
double S=High*c/2;
if (a==b&a==c) Harakter="Треугольник равносторонний";
else if(a==b||a==c||b==c) Harakter="Треугольник равнобедренный";
else if(a*a==b*b+c*c||b*b==a*a+c*c||c*c==a*a+b*b) Harakter="Треугольник прямоугольный";
else Harakter="Треугольник обычный";
double Angle_ac=Math.Round((Math.Asin(High/a)*57.29),1);
double Angle_bc=Math.Round((Math.Asin(High/b)*57.29),1);
double Angle_ab=Math.Round((180-Angle_ac-Angle_bc),1);
Console.WriteLine($"Периметр треугольника - {Perimetr}");
Console.WriteLine($"Площадь треугольника - {S}");
Console.WriteLine($"Угол АС треугольника - {Angle_ac} градусов");
Console.WriteLine($"Угол ВС треугольника - {Angle_bc} градусов");
Console.WriteLine($"Угол АB треугольника - {Angle_ab} градусов");
Console.WriteLine(Harakter);
}
