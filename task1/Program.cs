// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int A = new Random().Next(4, 11);  // длина массива

int[] array = fillArray(A);
Console.WriteLine($"Полученный массив - [{String.Join(",", array)}]");

int evenCount = evenNum(array);
Console.WriteLine($"Количество чётных чисел в массиве --> {evenCount}");

int[] fillArray(int size)  // функция заполнения массива от 100 до 1000.
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int evenNum(int[] array)  // функция поиска количества чётных чисел в заданном массиве.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}