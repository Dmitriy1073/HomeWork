// Функции заполнения и печати массивов
void FillArray(int[] collection)
{
    int length= collection.Length;
     int index=0; 
     while (index< length)
     {
        collection[index]=new Random().Next(1,10);
        index++;
     }
}

void PrintArray(int[] col)
{
    int count =col.Length;
    int position=0;
    while (position<count) 
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count=collection.Length;
    int index=0;
    int position=-1;
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position; 
}




Console.WriteLine("Введите размерность массива");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите искомое число");
int found=Convert.ToInt32(Console.ReadLine());
int[] array=new int[n];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos= IndexOf(array,found); 
Console.WriteLine(pos); 
