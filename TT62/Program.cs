// Задача 62. Напишите программу, которая заполнит спирально 
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int JustAFunctionForUWriteSmthng (string urtext)
{
    Console.WriteLine(urtext);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArraySpiral(int[,] array)
{
    int s = 1;
    for (int y = 0; y < array.GetLength(1); y++) 
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < array.GetLength(0); x++) 
    {
        array[x, array.GetLength(1) - 1] = s;
        s++;
    }
    for (int y = array.GetLength(1) - 2; y >= 0; y--) 
    {
        array[array.GetLength(0) - 1, y] = s;
        s++;
    }
    for (int x = array.GetLength(0) - 2; x > 0; x--) 
    {
        array[x, 0] = s;
        s++;
    }
        int c = 1;
        int d = 1;
 
    while (s < array.GetLength(0) * array.GetLength(1)) 
    {
        while (array[c, d + 1] == 0) 
        {
            array[c, d] = s;
            s++;
            d++;
        }
        while (array[c + 1, d] == 0) 
        {
            array[c, d] = s;
            s++;
            c++;
        }
        while (array[c, d - 1] == 0) {
                array[c, d] = s;
                s++;
                d--;
            }
        while (array[c - 1, d] == 0) 
        {
            array[c, d] = s;
            s++;
            c--;
        }
        }
         for (int x = 0; x < array.GetLength(0); x++) 
         {
            for (int y = 0; y < array.GetLength(1); y++) 
            {
                if (array[x, y] == 0) 
                {
                    array[x, y] = s;
                }
            }
        }
 
 
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

int indI = JustAFunctionForUWriteSmthng("I need a numbers of rows for Mtrx/array");
int indJ = JustAFunctionForUWriteSmthng("I need a numbers of columns for Mtrx/array");
int[,] WTFIsThat = new int [indI, indJ];
FillArraySpiral(WTFIsThat);
PrintThat(WTFIsThat);