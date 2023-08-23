



void FillArray2D(double[,] array, int leftBord, int rightBord)// функция заполнения 2D-массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftBord, rightBord);
        }
    }
}

void FillArray2DManual(double[,] array)// функция заполнения 2D-массива вручную
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите {i},{j} элемент массива- ");
            array[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }
}



void PrintArrayForm2D(double[,] array)// функция форматированного вывода 2D массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FindNum2D(double[,] array, int Num) //  функция нахождения введенного числа в 2Dмасиве (входит или нет)
{
    int f = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == Num)
            {
                f = f + 1;
                Console.WriteLine($"Искомое число {Num} является элементом {i},{j} массива");

            }
            else f = f + 0;
        }
    }
    if (f > 0) Console.WriteLine($"Искомое число {Num} является элементом массива");
    else Console.WriteLine("Искомое число не найдено");
}

void FindMedianColuns(double[,] array)// Функция находит и выводит среднее арифметическое столбца
{
    double[] Median = new double[array.GetLength(1)];
    double MedCol = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double Sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum = Sum + array[i, j];
        }
        //Console.WriteLine($" Сумма элементов {j} столбца= {Sum}");
        Median[j] =Math.Round(Sum / array.GetLength(0),2);
        Console.WriteLine($" Среднее арифметическое {j} столбца= {Median[j]}");

    }
}

// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2 = new double[m, n];
//закоментим пока Console.WriteLine("Введите левую границу диапазона значений");
//int leftBord = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите правую границу диапазона значений");
//int rightBord = Convert.ToInt32(Console.ReadLine());
//FillArray2D(array2, leftBord, rightBord);
FillArray2DManual(array2);
Console.Clear();
Console.WriteLine("Исходный массив");
PrintArrayForm2D(array2);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// ввод и заполнение массива случайными числами см. задачу 47
Console.WriteLine("Введите искомый элемент массива");
int Num = Convert.ToInt32(Console.ReadLine());
FindNum2D(array2,Num);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// ввод и заполнение массива случайными значениями см. задачу 47
FindMedianColuns(array2);













