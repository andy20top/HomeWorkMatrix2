// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int k = 1;

    int beginI = 0;
    int endI = rows-1;
    int beginJ = 0;
    int endJ = columns-1;

    int i = 0;
    int j = 0;
    while (k <= rows * columns)
    {
        matrix[i, j] = k;
        if (i == beginI && j < endJ) 
        { 
            j++;
        }
        else if (j == endJ && i < endI)
        {
            i++;
        }
        else if (i == endI && j > beginJ)
        {

            j--;
        }
        else 
        {
            i--;
        }

        if ((i == beginI + 1) && (j == beginJ))
        {
            beginI++;
            endI--;
            beginJ++;
            endJ--;
        }
        k++;
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(4, 4);
ShowMatrix(matrix);