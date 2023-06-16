// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int JustAFunctionForUWriteSmthng (string urtext)
{
    Console.WriteLine(urtext);
    return Convert.ToInt32(Console.ReadLine());
}

int [,,] UrRandomArray2d (int[,,] arrayOrMatrx)
{
    int temp = 10; 
    for (int i = 0; i < arrayOrMatrx.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOrMatrx.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOrMatrx.GetLength(2); k++)
            {
            arrayOrMatrx [i, j, k] = temp + 3;
            temp += 5;
            }
        }
    }
    return arrayOrMatrx;
}

void PrintThat (int [,,] arrayOrMatrx)
{
    for (int i = 0; i < arrayOrMatrx.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOrMatrx.GetLength(1); j++)
        {
            
            for (int k = 0; k < arrayOrMatrx.GetLength(2); k++)
            {
            Console.Write($"{arrayOrMatrx[i, j, k]}({i},{j},{k}) ");
            }
        }
    Console.WriteLine();    
    }
}



int indI = JustAFunctionForUWriteSmthng("I need a numbers of rows for Mtrx/array");
int indJ = JustAFunctionForUWriteSmthng("I need a numbers of columns for Mtrx/array");
int indK = JustAFunctionForUWriteSmthng("I need a numbers of some third measurement for Mtrx/array");
int[,,] WTFIsThat = new int [indI, indJ, indK];
UrRandomArray2d(WTFIsThat);
PrintThat(WTFIsThat);
