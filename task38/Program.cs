// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// class Program
// {
//     void Main()
//     {
//         double[] array = GetArray(6, 0, 100);

//         double maxNumber = FindMaxNumber(array);
//         double minNumber = FindMinNumber(array);

//         double result = Math.Round(maxNumber - minNumber, 2);

//         Console.Write($"[{string.Join("; ", array)}] => {maxNumber} - {minNumber} = {result}");
//     }

//     double[] GetArray(double size, double min, double max)
//     {
//         double[] result = new double[(int)size];
//         Random random = new Random();

//         for (int i = 0; i < size; i++)
//         {
//             result[i] = Math.Round(random.NextDouble() * (max - min) + min, 2);
//         }

//         return result;
//     }

//     double FindMaxNumber(double[] array)
//     {
//         double maxNumber = array[0];
//         for (int i = 1; i < array.Length; i++)
//         {
//             if (maxNumber < array[i])
//             {
//                 maxNumber = array[i];
//             }
//         }
//         return maxNumber;
//     }

//     double FindMinNumber(double[] array)
//     {
//         double minNumber = array[0];
//         for (int i = 1; i < array.Length; i++)
//         {
//             if (minNumber > array[i])
//             {
//                 minNumber = array[i];
//             }
//         }
//         return minNumber;
//     }
// }


double[] GetArray(double size, double min, double max)
{
    double[] result = new double[(int)size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(random.NextDouble() * (max - min) + min, 2);
    }

    return result;
}

double FindMaxNumber(double[] array)
{
    double maxNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

double FindMinNumber(double[] array)
{
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

double[] array = GetArray(6, 0, 100);

double maxNumber = FindMaxNumber(array);
double minNumber = FindMinNumber(array);

double result = Math.Round(maxNumber - minNumber, 2);

Console.Write($"[{string.Join("; ", array)}] => {maxNumber} - {minNumber} = {result}");

