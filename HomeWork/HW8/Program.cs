void FillArray2DManual(double[,] array)// функция заполнения 2D-массива вручную
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите {i},{j} элемент массива - ");
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
            System.Console.Write($"{array[i,j],4}   ");
        }
        Console.WriteLine();
    }
}





void SortingRow(double[,] array)// Функция сортировки по убыванию элементов в строках массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j=0;
        double MinRow = array[i, j];

        for (j = 0; j < array.GetLength(1); j++)
        {
           for (int n = j+1; n < array.GetLength(1); n++)
            { 
                if (array[i, j] > array[i,n])
                    {
                    MinRow = array[i, j];
                    array[i, j] = array[i,n];
                    array[i, n] = MinRow;
                    }
            }
        }
    }
}






void FindSummRow(double[,] array)// Функция находит cумму элементов строки и выводит номер строки с максимальной суммой
{
    double[] SummaStr = new double[array.GetLength(0)];
    int s1=array.GetLength(0);
    int s2=array.GetLength(1);
    Console.WriteLine($"число строк ={s1}, число столбцов={s2}");
    for (int i = 0; i < array.GetLength(0); i++)
     {
         double Sum = 0;
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Sum = Sum + array[i,j];
         }
         Console.WriteLine($" Сумма элементов {i} строки= {Sum}");
         SummaStr[i] =Sum;
     }
       double Max_Sum=SummaStr[0];
        int count=0;
    for (int n = 1; n < SummaStr.Length; n++)
    {
        if (SummaStr[n]> Max_Sum)
        { 
            Max_Sum=SummaStr[n];
            count=n;
        }
    }
    Console.WriteLine($"Максимальная сумма элементов = {Max_Sum} в строке= {count}");

}

void Proizvedenie (double [,] array2_1,double [,] array2_2, double [,] resultArray)//Функция перемножения матриц
    {
    for (int i = 0; i < array2_1.GetLength(0); i++)
	{
	    for (int j = 0; j < array2_2.GetLength(1); j++)
	    {
	        resultArray[i, j] = 0;
	        for (int k = 0; k < array2_1.GetLength(1); k++)
	        {
	            resultArray[i, j] =resultArray[i,j] + array2_1[i, k] * array2_2[k, j];
	        }
	    }
	}
    }
void PrintIndex(int[,,] array)// Функция вывода элементов 3D массива c индексoм 
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.WriteLine();
	            for (int k = 0; k < array.GetLength(2); k++)
	            {
	                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
	            }
	        }
	    }
	}


	
	
	void FillArray(int[,,] array)// Функция заполнения 3D массива не повторяющимися числами
	{
	    int count = 10;
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            for (int k = 0; k < array.GetLength(2); k++)
	            {
	                array[k, i, j] += count;
	                count = count+7;
	            }
	        }
	    }
	}


void FillArraySpiral(double[,] array, int n)// Функция спирального заполнения массива
{
    int i = 0, j = 0;
    int count = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = count++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = count++;
        for (k = 0; k < n - 1; k++) array[i, j--] = count++;
        for (k = 0; k < n - 1; k++) array[i--, j] = count++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}




// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// программа закоментирована
// Console.Clear();
// Console.WriteLine("Введите число строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array2 = new double[m, n];
// FillArray2DManual(array2);
// Console.WriteLine("Исходный массив");
// PrintArrayForm2D(array2);
// SortingRow(array2);
// Console.WriteLine("Сортированный массив");
// PrintArrayForm2D(array2);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// ввод массива взят из предыдущей задачи
// Console.Clear();
// Console.WriteLine("Введите число строк массива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов массива");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array2 = new double[m, n];
// FillArray2DManual(array2);
// Console.WriteLine("Исходный массив");
// PrintArrayForm2D(array2);
// FindSummRow(array2);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// программа закоментирована
// Console.Clear();
// Console.WriteLine("Введите размерность матриц");
// int m = Convert.ToInt32(Console.ReadLine());
// int n= m;
// double[,] resultArray= new double[m, n];
// double[,] array2_1 = new double[m, n];
// Console.WriteLine("Ввод первой матрицы");
// FillArray2DManual(array2_1);
// double[,] array2_2 = new double[m, n];
// Console.WriteLine("Ввод второй матрицы");
// FillArray2DManual(array2_2);
// Console.WriteLine("Первая матрица");
// PrintArrayForm2D(array2_1);
// Console.WriteLine("Вторая матрица");
// PrintArrayForm2D(array2_2);
// if (array2_1.GetLength(0) == array2_2.GetLength(1))
//         {
// 	    Proizvedenie(array2_1,array2_2,resultArray);
//         Console.WriteLine("Результат перемножения");
// 		PrintArrayForm2D(resultArray);
//      	}   
//     else Console.WriteLine(" Операция перемножения матриц невозможна ");




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] array3D=new int [2,2,2];
FillArray(array3D);
PrintIndex(array3D);
Console.WriteLine();



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine("Введите размерность квадратного маcсива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[n, n];
FillArraySpiral(array, n);
PrintArrayForm2D(array);


