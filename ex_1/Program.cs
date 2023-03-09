// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// Получить сумму положительных элементов массива
int GetSumPositiveElements(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

// -----------------------------------------------------------------------------------

// Получить сумму отрицательных элементов массива
int GetSumNegativeElements(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

// -----------------------------------------------------------------------------------

// Заполнить массив случайными числами
void FillIntArray(int[] array, int startRange, int endRange)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startRange, endRange + 1);
    }
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

int [] arrayInt = new int[12];

FillIntArray(arrayInt, -9, 9);

PrintIntArray(arrayInt);

Console.WriteLine($"Сумма положительных элементов = {GetSumPositiveElements(arrayInt)}");

Console.WriteLine($"Сумма отрицательных элементов = {GetSumNegativeElements(arrayInt)}");