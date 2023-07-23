// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] array = GetArray(4, 100, 1000);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");


int CountEvenNumbers(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

int countEven = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел: {countEven}");
