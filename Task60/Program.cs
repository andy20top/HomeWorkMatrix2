// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[, ,] Get3DMatrix(int rows, int columns, int deep, int minValue, int maxValue)
{
    int[, ,] matrix = new int[rows, columns, deep];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                matrix[i, j, k] = rand.Next(minValue, maxValue + 1);
            }
        }
    }

    return matrix;
}

void Show3DMatrix(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
                 Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");  
           }
            Console.WriteLine();
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


int rows = SetNumber("Enter number of lines");
int columns = SetNumber("Enter number of columns");
int deep = SetNumber("Enter z for 3d massive");
int minValue = SetNumber("Enter min value");
int maxValue = SetNumber("Enter max value");

int[, ,] matrix = Get3DMatrix(rows, columns, deep, minValue, maxValue);
Show3DMatrix(matrix);
