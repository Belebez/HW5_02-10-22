// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int A = new Random().Next(4, 11);  // длина массива

int[] array = fillArray(A);
Console.WriteLine($"Полученный массив - [{String.Join(",", array)}]");

int sumNum = sumUnevenIdx(array);
Console.WriteLine($"Cумма элементов массива, на нечётных позициях --> {sumNum}");

int[] fillArray(int size)  // функция заполнения массива от -100 до 100 включительно.
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}

int sumUnevenIdx(int[] array)  // функция складывает значения на нечётных позициях масcива.
{
    int sum = 0;
    for (int i = 1; i < array.Length;)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}  