// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// заполнить массив
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

// Найти элемент в массиве
bool SearchElement(int[] arrayInt, int searchNumber)
{
    for(int i = 0; i < arrayInt.Length; i++)
    {
        if(arrayInt[i] == searchNumber) return true;
    }
    return false;
}

// -----------------------------------------------------------------------------------

int[] array = new int[4] {3, 4, 6, 7};
PrintIntArray(array);
Console.Write("Введите число, которое хотите найти в массиве: ");
int searchedNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"-> {SearchElement(array, searchedNumber)}");
