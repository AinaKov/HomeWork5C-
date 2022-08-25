/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using System;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length - 1)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
    Console.WriteLine(collection[index] + ".");
}

void Sumeven(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int sum = 0;
    while (index < count)
    {
        if (collection[index] % 2 == 0)
        {
            sum += Convert.ToInt32(collection[index].ToString());
        }
        index++;
    }
    Console.Write("Сумма четных чисел = ");
    Console.WriteLine(sum);
}

Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];
FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Sumeven(array);