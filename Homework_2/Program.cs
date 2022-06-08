/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int rowNumber(int[,] array)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i;
        }
    }
    return index;
}


int[,] matrix = new int[3, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int index = rowNumber(matrix);
Console.WriteLine($"Cтрока - {index + 1}");