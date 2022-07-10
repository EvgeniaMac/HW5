// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[5];
int size = array.Length;
int count = 0;
int index = 0;

while (index<size)
{
    array[index]= new Random().Next(99,1000);
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}]");

for (int i =0; i<size; i++)
{
    if (array[i] %2 == 0)
    {
        count++;
    }
}
Console.WriteLine("В чассиве количество четных чисел = " + count);