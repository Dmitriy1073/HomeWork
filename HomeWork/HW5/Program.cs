// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array, int leftBord, int rightBord)// функция заполнения массива случайными числами
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(leftBord, rightBord);
            }
        }

int Score_Chetn(int[] array)// Функция вычисления количества четных элементов массива
    {
        int count=0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 ==0) count=count+1;
            }
        return count;
    }     

int Summ_Chetn(int[]array)// функция вычисления суммы нечетных элементов массива
{
    
        int sum_Chet=0;
        for (int i = 0; i < array.Length; i++)
            {
                if (i%2>0) sum_Chet=sum_Chet+array[i] ;
            }
        return sum_Chet;
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

int Max_number(int[]array)// Определение максимального элемента массива
{
    int Max=0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>Max) Max=array[i] ;
            }
            Console.WriteLine($"Максимальный элемент масива= {Max}");
        return Max;
}        

int Min_number(int[]array)// Определение минимального элемента массива
{
    int Min=array[0];
        for (int i = 1; i < array.Length; i++)
            {
                if (array[i]<Min) Min=array[i] ;
            }
            Console.WriteLine($"Минимальный элемент масива= {Min}");
        return Min;
}        


Console.Clear();
        Console.WriteLine("Введите размерность массива");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите левую границу диапазона значений");
        int leftBord=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите правую границу диапазона значений");
        int rightBord=Convert.ToInt32(Console.ReadLine());
        int [] array=new int[n];
        FillArray(array,leftBord,rightBord);
        Console.WriteLine("Введенный массив");
        PrintArrayForm(array);
        int Chet=Score_Chetn(array);
        Console.WriteLine($"Количество четных элементов массива = {Chet}");
       

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

 int S_CH=Summ_Chetn(array);
        Console.WriteLine($"Сумма элементов с нечетным индексом= {S_CH}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int Max_Number=Max_number(array);
int Min_Number=Min_number(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива= {Max_Number-Min_Number}");