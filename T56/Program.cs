// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int WritehereSomething (string txt)
{
    Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int indI = WritehereSomething("I need a numbers of rows");
int indJ = WritehereSomething("I need a numbers of columns");

int [,] UrRandomArray2d ()
{
    int[,] array = new int [indI, indJ];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random(). Next (1, 10);

        }
    }
    return array;
}

void PrintThat (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void IsNotASquar (int [,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        PrintThat(array);
    }
    else
    {
        Console.WriteLine ("I can't pront that, caz a number of columns and number of rows have same numbers. Try different numbers for that?");
    }
}


int [] SummsFindThere(int[,] array)
{
    int[] sumInLines = new int[array.GetLength(0)];
    Console.Write("All summs in each rows: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInLines[i] += array[i, j];
        }
    Console.Write($"{sumInLines[i]} ");
    }
    return sumInLines;
}

void minSumStrng (int[] array)
{
    int minI = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[minI] > array[i]) minI = i;
    }
            Console.Write($"Lowest summ of ellement: {array[minI]}");
            Console.WriteLine();
            Console.Write ($"Row with lowest summ: {minI+1}");
}


int [,] UOU = UrRandomArray2d();
IsNotASquar (UOU);
Console.WriteLine();
int [] UOUs = SummsFindThere(UOU);
Console.WriteLine();
minSumStrng (UOUs);