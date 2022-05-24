// Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] mass = new int[4, 5];
FillArray(mass);
Print(mass);
Console.WriteLine();

int[] sum = new int[mass.GetLength(0)];
for (int i = 0; i < mass.GetLength(0); i++)
{
    sum[i] = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sum[i] += mass[i, j];
    }
    Console.Write(sum[i] + " ");
}
Console.WriteLine();

int min = sum[0];
int minL = 0;
for (int l = 0; l < sum.Length; l++)
{
    if (sum[l] < min)
    {
        min = sum[l];
        minL = l;
    }
}
Console.WriteLine($"Строка {minL} с наименьшей суммой элементов.");