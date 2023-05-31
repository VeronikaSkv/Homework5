// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] Generatearray (int len)
{
    int [] array = new int [len];
    for (int i =0; i<len; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
return array;
}
int [] array =  Generatearray(4);
int summanumber = 0;
for (int i=0; i<array.Length; i++)
{
    if (i%2 !=0)
    {
        summanumber +=array[i];
    }
}
Console.WriteLine(String.Join (",",array));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях ровна {summanumber}");