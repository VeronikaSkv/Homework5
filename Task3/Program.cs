// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

int [] GenerateArray (int len)
{
    int [] array = new int [len];
    for (int i = 0; i<array.Length; i++)
    {
        array[i]=new Random().Next(-100,100);
    } return array;
}

int []array = GenerateArray(5);
int numberMax=array[0];
int numberMin = array[0];
for(int i=0; i<array.Length; i++)
{
    if (array[i]>numberMax)
    {
        numberMax=array[i];
    }
else if (array[i]<numberMin)
{
   numberMin = array[i];
}
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Разница между максимальным и минимальным элементом равна:{numberMax-numberMin}");