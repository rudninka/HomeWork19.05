//Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.
void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
    }
}}
void Print(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
Console.WriteLine();
}}
int [,]mass= new int [3,3];
FillArray(mass);
Print(mass);
Console.WriteLine();
int save;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int l = 0; l < mass.GetLength(1) - j - 1; l++)
        {
            if (mass[i, l] > mass[i, l+1])
        {
            save = mass[i, l];
            mass[i, l] = mass[i, l+1];
            mass[i, l+1] = save;
        }
        }
    }
}
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
}
