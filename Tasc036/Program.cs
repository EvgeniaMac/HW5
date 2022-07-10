// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[4];
int size = array.Length;
int result = 0;
int index = 0;

while (index<size)
{
    array[index]= new Random().Next(-100,101);
    index++;
}
Console.WriteLine($"[{String.Join(";", array)}]");

for (int i = 1; i < size; i= i+2)
{
    result += array[i];
}
Console.WriteLine("сумма чисел на нечетных позициях = " + result);