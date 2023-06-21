// Принимает на вход 2 числа и проверяет является ли первое число квадратом второго 
// а=25 В=5 ответ - да
// а=25 В=4 ответ - нет
Console.WriteLine("Введите первое число");

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");

int b = Convert.ToInt32(Console.ReadLine());
if (a==b*b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
Console.WriteLine("Первое число НЕ является квадратом второго");
// Программа выдает название дня недели по введенному номеру
Console.WriteLine("Введите номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day==1)
{
    Console.WriteLine("Понедельник");
    }
    else if(day==2)
    {
    Console.WriteLine("Вторник");
    }
    else if(day==3)
    {
    Console.WriteLine("Среда");
    }
    else if(day==4)
{
    Console.WriteLine("Четверг");
    }
    else if(day==5)
    {
    Console.WriteLine("Пятница");
    }
    else if(day==6)
    {
    Console.WriteLine("Суббота");
    }
    else if(day==7)
    {
    Console.WriteLine("Воскресенье");
    }
    else
        Console.WriteLine("Неправильно введено число");
