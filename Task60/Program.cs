// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.
void FillArray(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}
void Print(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " " + (i, j, k) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[, ,] mass = new int[3, 4, 3];
int min = 10;
if (mass.Length < 99 - 10)
{
for (int x = 0; x < mass.GetLength(0); x++)
{
    for (int y = 0; y < mass.GetLength(1); y++)
    {
        for (int z = 0; z < mass.GetLength(2); z++)
        {
            mass[x, y, z] = min;
            min++;
        }
    }
}}
FillArray(mass);
Print(mass);
