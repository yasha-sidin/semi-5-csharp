// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillRandomIntArray(int arraySize, int startRange, int endRange)
{
    int[] array = new int[arraySize];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startRange, endRange + 1);
    }
    return array;
}

// -----------------------------------------------------------------------------------

// Напечатать массив
void PrintIntArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
            break;
        }
        Console.Write($"{array[i]}, ");
    }
}

// -----------------------------------------------------------------------------------

// Посчитать количество элементов, принадлежащих опреденному промежутку
int SearchElementsFromRange(int[] array, int startSearch, int endSearch)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
        for(int i = startSearch; i <= endSearch; i++)
        {
            if(array[j] == i) count++;
        }
    
    return count;
}

// -----------------------------------------------------------------------------------

int[] array = FillRandomIntArray(123, 1, 150);
PrintIntArray(array);
int count = SearchElementsFromRange(array, 10, 99);
Console.WriteLine($"Количество элементов в диапозоне от 10 до 99 в массиве = {count}");

