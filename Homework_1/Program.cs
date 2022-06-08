/*Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/


void PrintArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}

int[,] Decreasingnumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;                                            
            for (int k = j + 1; k < array.GetLength(1); k++)                
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;    
            }
            int tmp = array[i, j];                                          
            array[i, j] = array[i, minPosition];                            
            array[i, minPosition] = tmp;                                    
        }

    }
    return array;
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Decreasingnumbers(matrix);
PrintArray(matrix);