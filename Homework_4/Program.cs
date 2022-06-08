//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintArray(int[,,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
            Console.Write($"{matr[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matr[i, j, k] = new Random().Next(1, 10); 
            }
        }
    }
}




int[,,] matrix = new int[5, 5, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);