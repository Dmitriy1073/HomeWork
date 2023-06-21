//Написать программу принимающую число и выдающее его квадрат
Console.WriteLine("Введите целое число");

int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.Write("Квадрат введенного числа - ");
Console.WriteLine(result);

if (num > 0)
{
    Console.WriteLine("Было введено положительное число");
}
else if (num == 0)
    Console.WriteLine("Был введен 0");
else 
    Console.WriteLine("Было введено отрицательное число");
Console.WriteLine("The END");