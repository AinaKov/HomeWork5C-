/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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

void Functia(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int max = collection[0];
    int min = collection[0];
    while (index < count)
    {
        if (collection[index] > max)
        {
            max = collection[index];

        }
        else if (collection[index] < min)
        {
            min = collection[index];
        }
        index++;
    }
    Console.Write("Максимальное число: ");
    Console.WriteLine(max);
    Console.Write("Минимальное число: ");
    Console.WriteLine(min);
    int result = max - min;
    Console.Write("Разница между элементами: ");
    Console.WriteLine(result);
}

Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];
FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Functia(array);