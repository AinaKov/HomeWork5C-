/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

using System;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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

void Even(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int i = 0;
    while (index < count)
    {
        if (collection[index] % 2 == 0)
        {
            i++;
            index++;
        }
        else
        {
            index++;
        }
    }
    Console.WriteLine("Количество четных чисел:");
    Console.WriteLine(i);
}

Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];
FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Even(array);