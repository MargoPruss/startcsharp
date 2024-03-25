// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних
// арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int [,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        //Console.WriteLine("   |");
        Console.WriteLine();
    }
}

double[] ArraySumAverage(int[,] matrix)
{
    double[] arrayResult = new double[matrix.GetLength(0)];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        arrayResult[i] = (double) sumRow / matrix.GetLength(1);

    }
    return arrayResult;
} 
void PrintArray(double[] array)
{
    Console.Write("[  ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
        {
            Console.Write($"{array[i]}  ");
        }
        else
        {
            Console.Write($"{array[i]}  ");
        }
    }
    Console.WriteLine("]");
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);

double[] array = ArraySumAverage(matrix);
PrintArray(array);