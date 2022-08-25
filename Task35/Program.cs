/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

using System;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 200);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    while (index < count - 1)
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
    Console.WriteLine(collection[index] + ".");
}

int Counter(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] > 10 & collection[index] < 99)
        {
            position++;
        }
        index++;
    }
    return position;

}

int[] array = new int[123];

FillArray(array);
PrintArray(array);
int i = Counter(array);
Console.WriteLine("Количество чисел больше 10 но меньше 99: " + i);









