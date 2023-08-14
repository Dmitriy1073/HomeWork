
        //########################## Семинар 4

        // Задача №31 Задать массив из N элементов, заполнить его случайными числами из промежутка (-X;Y) 
        //и найти сумму отрицательных и положительных элементов массива
        // 1 способ

        // void FillArray(int[] array,int leftBord, int rightBord)
        // {
        //     for (int i = 0; i < array.Length ; i++)
        //     {
        //         array[i] = new Random().Next(leftBord, rightBord);
        //     }

        // }



        // void PrintArray(int[]array)
        // {
        //     for (int i = 0; i < array.Length ; i++)
        //     {
        // Console.Write($"{array[i]} ");
        //     }
        //     Console.WriteLine();
        // }


        // void SumMaxMin(int[] array)
        // {
        //     int sumPlus=0;
        //     int sumMinus=0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[i]>0)
        //         {
        //            sumPlus=sumPlus+array[i]; 
        //         } 
        //         else sumMinus=sumMinus+array[i];
        //     }
        // Console.WriteLine($"Сумма положительных элементов массива ={sumPlus}");
        // Console.WriteLine($"Сумма отрицательных элементов массива ={sumMinus}");
        // }





        // Console.Clear();
        // Console.WriteLine("Введите размерность массива");
        // int n=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите левую границу диапазона значений");
        // int leftBord=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите правую границу диапазона значений");
        // int rightBord=Convert.ToInt32(Console.ReadLine());
        // int [] array=new int[n];
        // FillArray(array,leftBord,rightBord);
        // PrintArray(array);

        // SumMaxMin(array);


        // Задача №31 Задать массив из N элементов, заполнить его случайными числами из промежутка (-X;Y) 
        //и найти сумму отрицательных и положительных элементов массива
        // 2 способ

        // void FillArray(int[] array, int leftBord, int rightBord)
        // {
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         array[i] = new Random().Next(leftBord, rightBord);
        //     }

        // }



        // void PrintArray(int[] array)
        // {
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         Console.Write($"{array[i]} ");
        //     }
        //     Console.WriteLine();
        // }


        // int [] SumMaxMin (int[] array)
        // {
        //     int[] sumPM = new int[2];
        //     int sumPlus=0;
        //     int sumMinus=0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[i]>0)
        //         {
        //            sumPlus=sumPlus+array[i]; 
        //         } 
        //         else 
        //             sumMinus=sumMinus+array[i];
        //     }
        //     sumPM[0]=sumPlus;
        //     sumPM[1]=sumMinus;
        // return sumPM;
        // }
        //     //






        // Console.Clear();
        // Console.WriteLine("Введите размерность массива");
        // int n = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите левую границу диапазона значений");
        // int leftBord = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите правую границу диапазона значений");
        // int rightBord = Convert.ToInt32(Console.ReadLine());
        // int[] array = new int[n];
        // FillArray(array, leftBord, rightBord);
        // PrintArray(array);

        // SumMaxMin(array);
        // PrintArray(SumMaxMin(array));

        //Console.WriteLine($"Сумма положительных элементов массива ={sumPM[0]}");
        //Console.WriteLine($"Сумма отрицательных элементов массива ={sumPM[1]}");


        // задача №32 Написать программу замены отрицательных элементов массива на положительные

        void FillArray(int[] array, int leftBord, int rightBord)// функция заполнения массива случайными числами
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(leftBord, rightBord);
            }
        }

        void PrintArray(int[] array)// функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

        }

        void Reverse(int[] array) // функция замены отр. элементов на положительные
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) array[i] = -array[i];
                else array[i] = array[i];

            }
        }




        // // тело программы
        // Console.Clear();
        // Console.WriteLine("Введите размерность массива");
        // int n = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите левую границу диапазона значений");
        // int leftBord = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите правую границу диапазона значений");
        // int rightBord = Convert.ToInt32(Console.ReadLine());
        // int[] array = new int[n];
        // FillArray(array, leftBord, rightBord);
        // Console.WriteLine("Исходный массив");
        // PrintArray(array);
        // Console.WriteLine("_________________________________________________________________");
        // Reverse(array);
        // Console.WriteLine("Замененый массив");
        // PrintArray(array);
        // Console.WriteLine("_________________________________________________________________");

        // Задача №33 Написать программу. которая определяет есть ли введенное число в составе элементов массива

        void FindNum(int[] array, int Num)
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




        // тело программы ( функции заполнения и печати выше в предыдущей задаче)
        // Console.Clear();
        // Console.WriteLine("Введите размерность массива");
        // int n = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите левую границу диапазона значений");
        // int leftBord = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите правую границу диапазона значений");
        // int rightBord = Convert.ToInt32(Console.ReadLine());
        // int[] array = new int[n];
        // Console.WriteLine("Введите искомое значение");
        // int Num = Convert.ToInt32(Console.ReadLine());

        // FillArray(array, leftBord, rightBord);
        // Console.WriteLine("Исходный массив");
        // PrintArray(array);
        // Console.WriteLine("_________________________________________________________________");
        // FindNum(array, Num);
        // //Console.WriteLine("Замененый массив");
        // //PrintArray(array);
        // Console.WriteLine("_________________________________________________________________");













        //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        //3, 5 -> 243 (3⁵)
        //2, 4 -> 16



        // Console.Clear();
        // Console.WriteLine("Введите основание степени");
        // int A = Convert.ToInt32(Console.ReadLine()); //double A
        // Console.WriteLine("Введите показатель степени");
        // int B = Convert.ToInt32(Console.ReadLine()); //double B
        //double Rez = Math.Pow(A,B);

        //Console.WriteLine($"число {A} в степени {B} = {Rez}");
        // int rez1=1;
        // for(int i=1; i<=B; i++)
        // {
        //     rez1=rez1*A;
        // }
        // Console.WriteLine($"число {A} в степени {B} = {rez1}");

        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        //452 -> 11
        //82 -> 10
        //9012 -> 12

        // Console.Clear();
        // Console.WriteLine("Введите целое число");
        // int Num = Convert.ToInt32(Console.ReadLine());
        // int sum=0;

        // while (Num>10)
        // {
        // int ost= Num%10;
        // Num=Num/10;
        // sum=sum+ost;
        //  Console.WriteLine(ost);
        // }
        // Console.WriteLine(Num);
        // sum=sum+Num;
        // Console.WriteLine($"Сумма чисел в числе={sum}");


        // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        // 6, 1, 33 -> [6, 1, 33]



        void FillArayNum(int[] array)// функция заполнения массива вручную
        {
            for (int i = 0; i < array.Length; i++)
            {
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
        Console.Clear();
        Console.WriteLine("Введите размерность массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        FillArayNum(array);
        PrintArrayForm(array);

        // Задать массив случайных чисел в выбранном диапазоне, 
        // найти количество элементов заданного массива, которые находятся в зиапазоне от А до В

        void FindNumDiapason(int[] array, int FindBordLeft, int FindBordRight)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= FindBordRight )
                {
                 if (& array[i]=> FindBordLeft)
                   {
                    count = count + 1;
                   }
                }
                count = count + 0;
            } 
            
            // Console.WriteLine($"Искомое число является элементом {i} массива");  
        }
        
            
    }
    if (f > 0) Console.WriteLine($"количество совпадений {f}");
        else Console.WriteLine("Искомое число не найдено");
}








Console.Clear();
        Console.WriteLine("Введите размерность массива");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите левую границу диапазона значений");
        int leftBord = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите правую границу диапазона значений");
        int rightBord = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Введите левую границу искомого диапазона значений");
        int FindBordLeft = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите правую границу искомого диапазона значений");
        int FindBordRight = Convert.ToInt32(Console.ReadLine());
        FillArray(array, leftBord, rightBord);
        PrintArray(array);
        FindNumDiapason(array, FindBordLeft, FindBordRight);

