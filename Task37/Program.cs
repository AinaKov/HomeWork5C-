/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

using System;

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
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

void Multiplication(int[] collection)
{
    int count = collection.Length - 1;
    int index = 0;
    int i = 0;
    while (index < count)
    {
        i++;
        index++;
        count = count - 1;
    }
    index = 0;
    count = collection.Length - 1;
    int[] newnumbers = new int[i];
    while (index < count)
    {
        newnumbers[index] = Convert.ToInt32(collection[index].ToString()) * Convert.ToInt32(collection[count].ToString());
        count = count - 1;
        index++;
    }
    index = 0;
    Console.WriteLine("Произведение пар чисел: ");
    while (index < i-1)
    {
        Console.Write($"{newnumbers[index]}, ");
        index++;
    }
    Console.WriteLine(newnumbers[index] + ".");
}

Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];
FillArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Multiplication(array);

// Скажите пожалуйста, можно ли вновь созданный массив заставить снова обратиться к функции PrintArray для красивого отображения?