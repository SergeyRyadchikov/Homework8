// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 4

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] MultiplicationTwoMatrix(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return array1;
}



Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] array = size.Split(",");
int[,] massive1 = new int[Convert.ToInt32(array[0]), Convert.ToInt32(array[1])];
int[,] massive2 = new int[Convert.ToInt32(array[0]), Convert.ToInt32(array[1])];

FillMatrix(massive1);
Console.WriteLine("Матрица №1");
PrintMatrix(massive1);
Console.WriteLine();
Console.WriteLine("Матрица №2");
FillMatrix(massive2);
PrintMatrix(massive2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
PrintMatrix(MultiplicationTwoMatrix(massive1, massive2));