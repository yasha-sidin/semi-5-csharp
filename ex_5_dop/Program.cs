// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Создаем и заполняем массив числами
int[] GetFillRandomIntArray(int arraySize, int startRange, int endRange)
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

// Находим произведение пар чисел по краям массива

void GetMultiCouple(int[] array)
{
    int count = array.Length - 1;
    if(array.Length % 2 == 0)
    {
        for(int i = 0; i < array.Length / 2; i++)
        {
            if(array[i] == array[count])
            {
                Console.Write($"{array[i]}");
                break;
            }
            int result = array[i] * array[count];
            Console.Write($"{result} ");
            count--;
        }
    }
    else
    {
        for(int i = 0; i <= array.Length / 2; i++)
        {
            if(array[i] == array[count])
            {
                Console.Write($"{array[i]}");
                break;
            }
            int result = array[i] * array[count];
            Console.Write($"{result} ");
            count--;
        }
    }
}

// -----------------------------------------------------------------------------------

int[] array = GetFillRandomIntArray(10, 1, 9);
PrintIntArray(array);
GetMultiCouple(array);