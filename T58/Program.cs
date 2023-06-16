// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int WritehereSomething (string txt)
{
    Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}



int [,] UrRandomArray2d (int[,] array)
{
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


void isItareEqual (int [,] array, int [,] arrayS)
{
    if (array.GetLength(0) != arrayS.GetLength(1))
    {
        Console.WriteLine ("Oh, srry, can't to do it.. caz.. oh, u know a rule? allright, I'll tell to u,Two matrices can be multiplied only if the number of columns in the first matrix equals the number of rows in the second matrix ^_^ try other numbers pls ");
    }
    else
    {
        Console.WriteLine ("Wait a sec, I need a time for do it :3");
    }
}

int [,] hardMathMulty (int [,] array, int [,] arrayS)
{
    int [,] readyhardMatrix = new int [array.GetLength(0), arrayS.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < arrayS.GetLength(1); j++)
        {
            for (int k = 0; k < arrayS.GetLength(0); k++)
            {
                readyhardMatrix[i, j] += array[i, k]*arrayS[k, j];
            }

        }
    }
    return readyhardMatrix;
}

int indI = WritehereSomething("I need a numbers of rows for first Mtrx");
int indJ = WritehereSomething("I need a numbers of columns first Mtrx");
int[,] FirstOuO = new int [indI, indJ];
UrRandomArray2d(FirstOuO);
PrintThat(FirstOuO);
int indM = WritehereSomething("I need a numbers of rows second Mtrx");
int indN = WritehereSomething("I need a numbers of columns second Mtrx");
int[,] SecondUoU = new int [indM, indN];
UrRandomArray2d(SecondUoU);
PrintThat(SecondUoU);
Console.WriteLine();
isItareEqual(FirstOuO, SecondUoU);
int [,] UOU = hardMathMulty(FirstOuO, SecondUoU);
Thread.Sleep(1500);
PrintThat(UOU);


// void PrintBoth (int [,] array, int [,] arrayS)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write(" | | ");
//         for (int j = 0; j < arrayS.GetLength(1); j++)
//         {
//             Console.Write(arrayS [i, j]+ " ");
//         }    
//         Console.WriteLine();
//     }
// }
