// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
//int num1=Convert.ToInt32(Console.ReadLine()); //вместо Convert.ToInt32 можно использовать
int num = int.Parse(Console.ReadLine()!);
if (num > 99 && num < 999)
{
    Console.WriteLine("Вторая цифра введенного числа - " + (num / 10) % 10);
}

else Console.WriteLine("Введено неверное число");

// //Задача 13: Напишите программу, которая выводит третью цифру заданного 
// //числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine()!);
// if (num > 99)
// {
//     int count = 0;
//     while (num > 1000)
//     {
//         num = num / 10;
//         count++;
//     }
//     Console.WriteLine(num % 10);
// }
// else Console.WriteLine("Третьей цифры нет");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// string[] week = { "рабочий", "рабочий", "рабочий", "рабочий", "рабочий", "выходной", "выходной" };
// string[] name_week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
// Console.WriteLine("Введите номер дня недели");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 7 && num >= 1)
// {
//     Console.WriteLine(name_week[num - 1] + " - " + week[num - 1]);
// }
// else Console.WriteLine("Введен несуществующий номер дня недели");

// Задача необязательная 2:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

// string[] name = { "программистов", "программист", "программиста", "программиста", "программиста", "программистов", "программистов", "программистов", "программистов", "программистов" };
// Console.WriteLine("Введите число людей в комнате");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 10)
// {
//     Console.WriteLine(name[num]);
// }
// else Console.WriteLine(name[num%10]);


//#############Семинар №3  ############################################

       Console.WriteLine("Hello, World!");
        // **** программа принимает на вход число и выдает цифру его второго справа разряда
        // Console.WriteLine("Введите число больше 10");
        //  int num = Convert.ToInt32(Console.ReadLine());
        //         Console.WriteLine($"Введено число - {num}");
        //         if (num < 10)
        //         {
        //             Console.WriteLine("Введено неправильное число");
        //         }
        //         else
        //         {
        //             while (num > 99)
        //             {
        //                 num = num / 10;
        //             }
        //             num = num % 10;
        //             Console.WriteLine($"вторая  цифра введенного числа - {num}");
        //         }
        // **** Программа принимает на вход координаты точки и выдает принадлежность точки к определенно координатной 
        // **** четверти решенная через условие
        // Console.WriteLine("Введите координату Х, отличную от 0");
        // int X = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите координату Y, отличную от 0");
        // int Y = Convert.ToInt32(Console.ReadLine());
        // if (X>0 && Y>0){Console.WriteLine("точка принадлежит к 1 четверти");}
        // else if(X<0 && Y>0){Console.WriteLine("точка принадлежит к 2 четверти");} 
        //  else if(X<0 && Y<0){Console.WriteLine("точка принадлежит к 3 четверти");}
        // else if(X>0 && Y<0){Console.WriteLine("точка принадлежит к 4 четверти");}
        // else {Console.WriteLine("Точка лежит на координатной оси");}
        //
        //
        // **** Программа принимает на вход координаты точки и выдает принадлежность точки к определенно координатной 
        // **** четверти решенная через функции

        // void ChekKoord(int X, int Y) //Функция выбора четверти не возвращающая никаких значений
        // {
        //     if (X > 0 && Y > 0) { Console.WriteLine("точка принадлежит к 1 четверти"); }
        //     else if (X < 0 && Y > 0) { Console.WriteLine("точка принадлежит к 2 четверти"); }
        //     else if (X < 0 && Y < 0) { Console.WriteLine("точка принадлежит к 3 четверти"); }
        //     else if (X > 0 && Y < 0) { Console.WriteLine("точка принадлежит к 4 четверти"); }
        //     else { Console.WriteLine("Точка лежит на координатной оси"); }
        // }


        // int ChekKoord2(int X, int Y)  //Функция выбора четверти возвращающая номер четверти Rezult
        // {
        //     int Rezult = 0;

        //     if (X > 0 && Y > 0) { Rezult = 1; }
        //     else if (X < 0 && Y > 0) { Rezult = 2; }
        //     else if (X < 0 && Y < 0) { Rezult = 3; }
        //     else if (X > 0 && Y < 0) { Rezult = 4; }
        //     return Rezult;
        // }


        // // тело программы
        // Console.WriteLine("Введите координату Х, отличную от 0");
        // int X = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите координату Y, отличную от 0");
        // int Y = Convert.ToInt32(Console.ReadLine());
        // ChekKoord(X, Y);
        // Console.WriteLine("------------------------------------------------------------------");
        // Console.WriteLine($"Это четверть №  {ChekKoord2(X, Y)}");


        // **** Программа принимает на вход номер координатной четверти и и выдает возможные координаты точки   
        // ****  решенная через функции

        // void ChekKoord(int coord) //Функция выбора возможных координат не возвращающая никаких значений
        // {

        //         if (coord == 1) { Console.WriteLine("точка имеет координаты Х>0 Y>0"); }
        //         else if (coord == 2) { Console.WriteLine("точка имеет координаты Х<0 Y>0"); }
        //         else if (coord==3) { Console.WriteLine("точка имеет координаты Х<0 Y<0"); }
        //         else if (coord==4) { Console.WriteLine("точка имеет координаты Х>0 Y<0"); }
        //         else { Console.WriteLine("Введено неверное значение"); }
        //     }

        //     string ChekKoord2(int X)  //Функция выбора четверти возвращающая номер четверти Rezult
        //     {
        //         string Rezult = "Incorrect number";

        //         if (X == 1) { Rezult ="X > 0 & Y > 0" ; }
        //         else if (X == 2 ) { Rezult ="X <0 & Y > 0" ; }
        //         else if (X == 3 ) { Rezult ="X <0 & Y < 0"; }
        //         else if (X == 4 ) { Rezult ="X >0 & Y < 0"; }
        //         return Rezult;
        //     }


        // // тело программы
        // Console.WriteLine("Введите номер четверти от 1 до 4");
        // int X = Convert.ToInt32(Console.ReadLine());

        // ChekKoord(X);
        // Console.WriteLine("------------------------------------------------------------------");
        // Console.WriteLine($"Возможные для этой четверти координаты  {ChekKoord2(X)}");



        //******* Программа принимает на вход координаты двух точек и выдает расстояние между ними


        // double Lenght(double x1, double x2, double y1, double y2) // функция вычисления длины отрезка по координатам точек
        // {
        //     double Lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //     return Lenght;
        // }



        // Console.WriteLine("Введите координату Х точки А");// Тело программы
        // double x1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Y точки А");// Тело программы
        // double y1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Х точки B");// Тело программы
        // double x2 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Y точки B");// Тело программы
        // double y2 = Convert.ToDouble(Console.ReadLine());
        // Double L = Lenght(x1, x2, y1, y2);
        // Console.WriteLine($"Длина отрезка AB -  {Math.Round(L,3)}");



        //******* Программа принимает на вход число N и выдает на выходе таблицу квадратов от 1 до N

        // void Kvadr(int N) // функция вывода последовательности квадратов
        // {
        //     int I = 1;
        //     while (I < N + 1)
        //     {
        //         Console.Write($"{I * I}, ");
        //         I++;
        //     }
        //     Console.WriteLine();
        // }



        // Console.WriteLine("Введите целое положительное число ");// Тело программы
        // int N = Convert.ToInt32(Console.ReadLine());
        // if (N>0) Kvadr(N);
        // else { Console.WriteLine("Введено неверное значение числа"); }

        //Задача 23 ******* Программа принимает на вход число N и выдает на выходе таблицу кубов от 1 до N

        // void Kube(int N)   // функция вывода последовательности кубов
        //  {
        //      int I = 1;
        //      while (I < N + 1)
        //     {
        //         Console.Write($"{Math.Pow(I, 3)}, ");
        //         I++;
        //     }
        //     Console.WriteLine();
        // }



        // Console.WriteLine("Введите целое положительное число ");// Тело программы
        // int N = Convert.ToInt32(Console.ReadLine());
        // if (N>0) Kube(N);
        // else { Console.WriteLine("Введено неверное значение числа"); }






        //Задача 21******* Программа принимает на вход координаты двух точек в 3D и выдает расстояние между ними


        // double Lenght(double x1, double x2, double y1, double y2, double z1, double z2) // функция вычисления длины отрезка по координатам точек
        // {
        //     double Lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        //     return Lenght;
        // }



        // Console.WriteLine("Введите координату Х точки А");// Тело программы
        // double x1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Y точки А");// Тело программы
        // double y1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Z точки А");// Тело программы
        // double z1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Х точки B");// Тело программы
        // double x2 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Y точки B");// Тело программы
        // double y2 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Введите координату Z точки B");// Тело программы
        // double z2 = Convert.ToDouble(Console.ReadLine());
        // Double L = Lenght(x1, x2, y1, y2, z1,z2);
        // Console.WriteLine($"Длина отрезка AB -  {Math.Round(L,2)}");




        //Задача 19 ******* Программа принимает на вход 5 значное число и проверяет неявляется ли оно палиндромом

        // void Pal(int N)   // функция определения принадлежности
        // {

        //     int[] array={0,0,0,0,0};
        //     int I = 0;
        //     while (I < 5)
        //     {
        //         //Console.Write($"{N%10}, ");
        //         array[I]=N%10;
        //         //Console.Write(array[I]);
        //         N= N/10;

        //                 I++;
        //     }
        //     if(array[0]==array[4]&&array[1]==array[3]) Console.WriteLine("введенное число является палиндромом"); 
        //     else      Console.WriteLine("This  number is not palindron ");
        // }



        // Console.WriteLine("Введите целое положительное пятизначное число ");// Тело программы
        // int N = Convert.ToInt32(Console.ReadLine());
        // if (N > 9999 && N < 99999) Pal(N);
        // else { Console.WriteLine("Введено неверное значение числа"); }




        //################## Лекция №4 Двумерные массивы и рекурсия
        // Синтаксис двумерного массива string [,] table = new string[2,5]
        // string - тип данных в массиве 
        // [,] - признак двумерного массива
        // table - имя массива
        // new string [2,5] - новый массив строковых значений размерностью 2 строки и 5 столбцов
        // структура данного массива
        // table[0,0] table[0,1]table[0,2]table[0,3]table[0,4]
        // table[1,0] table[1,1]table[1,2]table[1,3]table[1,4]
        // как и  в одномерных массивах нумерация индексов начинается с 0
        //инициализация строк - String.Empty ( поумолчанию будет пробел в качестве элемента)


        // string [,] table = new string[2,5];
        // table [1,2]="слово";

        // for (int Rows=0; Rows<2; Rows++)
        // {
        //     for(int columns=0;columns<5;columns++)
        //     {
        //         Console.WriteLine($"-{table[Rows,columns]}-");
        //     }
        // }

        // int[,] matrix = new int [3,4];

        // //for (int i=0; i<3; i++)
        // for (int i=0; i<matrix.GetLength(0); i++)
        // {
        //     //for(int j=0;j<4;j++)
        //     for(int j=0;j<matrix.GetLength(1);j++)
        //     {
        //         Console.Write($"{matrix[i,j]} ");
        //     }
        //     Console.WriteLine();
        // }



        // void PrintArray(int[,] matr)
        // {
        //     for (int i=0; i<matr.GetLength(0); i++)
        //     {
        //         for(int j=0;j<matr.GetLength(1);j++)
        //         {
        //             Console.Write($"{matr[i,j]} ");
        //         }
        //         Console.WriteLine();
        //     }
        // }


        // void FillAray(int[,] matr)
        // {
        //   for (int i=0; i<matr.GetLength(0); i++)
        //     {
        //         for(int j=0; j<matr.GetLength(1);j++)
        //         {
        //             matr[i,j]=new Random().Next(1,10);
        //         }

        //     }  
        // }



        // int[,] matrix = new int [3,4];
        // PrintArray(matrix);
        // Console.WriteLine();
        // FillAray(matrix);
        // PrintArray(matrix);





        //########################рекурсия - функция вызывающая сама себя внутри функции

        // примеры применения рекурсии:
        // 1. закрашивание замкнутых объектов 
        // 2. вычисление факториала
        // 3. вычисление чисел Фибоначи

        // примеры применения
        // закрашивание замкнутой области, для этого применяется пошаговое изменение координат (применяется только в небольших объемах) 
        // при этом изменение координат делается пошагово - 
        // х-1,у (вверх) 
        // х,у-1 (влево)
        // х+1,у (вниз)
        // х,У+1 (вправо)

        // Пример реализации (не работает ввод массива)

        // int[,] Pic = new int[,];
        // {
        //     { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        //     { 0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
        //     // { 0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0},
        //     // { 0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
        //     // { 0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
        //     // { 0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
        //     // { 0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0},
        //     // { 0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0},
        //     };

        // void PrintImage(int[,] image)
        // {
        //     for (int i = 0; i < image.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < image.GetLength(0); j++)
        //         {
        //             if (image(i, j) == 0) 
        //             {
        //                 Console.Write(" ");
        //             }
        //             else Console.Write($"{image[i, j]}");
        //         }
        //     }

        //     PrintImage(Pic);


        // Факториал

        // double Faktorial(int n)
        // {
        //     // 1!=1
        //     if (n == 1) return 1;
        //     else return n* Faktorial(n-1);

        // }



        // Console.WriteLine("Введите целое положительное число");
        // int n=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"факториал введенного числа {Faktorial(n)}");


        // числа Фибоначи
        // f(1)=1
        // f(2)=1
        // f(3)=2
        // f(4)=3
        // f(n)=f(n-1)+f(n-2)

        // int Fibon(int n)
        // {
        //     if (n == 1 || n == 2) return 1;
        //     else return Fibon(n - 1) + Fibon(n - 2);
        // }





        // Console.WriteLine("Введите целое положительное число");
        // int n = Convert.ToInt32(Console.ReadLine());
        // for (int I = 1; I <= n; I++)
        // {
        //     Console.WriteLine($"число Фибоначи ({I})= {Fibon(I)}");
        // }
