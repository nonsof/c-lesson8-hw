// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System.Collections.Specialized;
using System.Globalization;

int WritehereSomething (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = WritehereSomething ("Input a lenght of rows");
int b = WritehereSomething ("Input a lenght of columns");

int[,] GetArray2d ()
{
    int[,] array = new int [a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random(). Next (1, 10);

        }
    }
    return array;
}

void PrintArray (int [,] array)
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

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // запрашиваем пробегание по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++) // запрашиваем пробегание по столбцам
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++) // вводим некий индекс, который позволит нам проверить наличие большего или меньшего числа далее
            {
                if (array[i, k] < array[i, k + 1]) // сравниваем текущее и последующее число
                {
                    int temp = array[i, k + 1]; // вводим переменную, которая бы равнялась последующему от проверяемого числа
                    array[i, k + 1] = array[i, k]; // заменяем числа при выполнении условия
                    array[i, k] = temp; //заменяем число обратно
                }
            }
        }
    }
}


Console.WriteLine();
int [,] genArray = GetArray2d();
PrintArray (genArray);
Console.WriteLine();
SortToLower(genArray);
Console.WriteLine();
PrintArray(genArray);