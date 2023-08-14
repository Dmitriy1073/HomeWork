// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Pal(int N)   // функция определения палиндрома
        {

            int[] array={0,0,0,0,0};
            int I = 0;
            while (I < 5)
            {
                //Console.Write($"{N%10}, ");
                array[I]=N%10;
                //Console.Write(array[I]);
                N= N/10;

                        I++;
            }
            if(array[0]==array[4]&&array[1]==array[3]) Console.WriteLine("введенное число является палиндромом"); 
            else      Console.WriteLine("This  number is not palindron ");
        }


Console.Clear();
        Console.WriteLine("Введите целое положительное пятизначное число ");// Тело программы
        int N = Convert.ToInt32(Console.ReadLine());
        if (N > 9999 && N < 99999) Pal(N);
        else { Console.WriteLine("Введено неверное значение числа"); }



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenght(double x1, double x2, double y1, double y2, double z1, double z2) // функция вычисления длины отрезка по координатам точек
        {
            double Lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
            return Lenght;
        }



        //Console.Clear();// Тело программы
        Console.WriteLine("Введите координату Х точки А");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Y точки А");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Z точки A");
        double z1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату Х точки B");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Y точки B");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координату Z точки B");
        double z2 = Convert.ToDouble(Console.ReadLine());

        Double L = Lenght(x1, x2, y1, y2, z1, z2);

        Console.WriteLine($"Длина отрезка AB -  {Math.Round(L,3)}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kube(int N)   // функция вывода последовательности кубов
         {
             int I = 1;
             while (I < N + 1)
            {
                Console.Write($"{Math.Pow(I, 3)}, ");
                I++;
            }
            Console.WriteLine();
        }



        Console.WriteLine("Введите целое положительное число ");// Тело программы
        int N1 = Convert.ToInt32(Console.ReadLine());
        if (N1>0) Kube(N1);
        else { Console.WriteLine("Введено неверное значение числа"); }