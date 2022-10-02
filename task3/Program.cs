//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int A = new Random().Next(4, 6);  // длина массива

double[] array = fillArray(A);
Console.WriteLine($"Полученный массив - [{String.Join(";", array)}]");

double diffNum = diffMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом --> {diffNum}");

double[] fillArray(int size)  // функция заполнения массива от -100 до 100 включительно, вещественными числами. Округление до 2 знаком после запятой.
{
    double[] result = new double[size];
    double maxValue = 101;
    double minValue = -100;
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round((new Random().NextDouble()*(maxValue - minValue) + minValue), 2);
    }
    return result;
}

double diffMaxMin(double[] array)  // функция возвращает разницу между максимальным и минимальным значением массива.
{
    double maxNum = array[0];
    double minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
        else if (minNum > array[i])
        {
            minNum = array[i];
        }
    }
    double diff = maxNum - minNum;
    return diff;
}  