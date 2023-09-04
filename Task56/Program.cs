// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }

    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SetNumber(string msg)
{
    Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NumberRowMin(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int indexMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumInRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumInRow += matrix[i,j];
        }
        sum[i] = sumInRow;
    }

    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[indexMinSum] > sum[i])
        {
            indexMinSum = i;
        }
    }
    return indexMinSum;
}

int rows = SetNumber("Enter number of lines");
int columns = SetNumber("Enter number of columns");
int minValue = SetNumber("Enter min value");
int maxValue = SetNumber("Enter max value");

int[,] matrix = GetMatrix(rows, columns, minValue, maxValue);
ShowMatrix(matrix);

Console.WriteLine($"Строка с наименьшей суммой под номером {NumberRowMin(matrix)+1}");
