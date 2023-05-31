// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных
//  чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GenerateArray ()
{
    int [] array = new int [4];
    for (int i = 0; i<array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
    } return array;
}

int []array = GenerateArray();
int Numberchet=0;
for(int i=0; i<array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        Numberchet ++;
    }

}
Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Количество четных чисел равно:{Numberchet}");