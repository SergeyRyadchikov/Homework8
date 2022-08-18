// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
//  двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


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

void SortMatrixRows(int[,] matrix, char way)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (way == '<')
            {
                int minPosition = j;
                for (int z = j + 1; z < matrix.GetLength(1); z++)
                {
                    if (matrix[i, z] < matrix[i, minPosition]) minPosition = z;
                }
                int temporarray = matrix[i, j];
                matrix[i, j] = matrix[i, minPosition];
                matrix[i, minPosition] = temporarray;
            }
            else
            {
                int maxPosition = j;
                for (int z = j + 1; z < matrix.GetLength(1); z++)
                {
                    if (matrix[i, z] > matrix[i, maxPosition]) maxPosition = z;
                }
                int temporarray = matrix[i, j];
                matrix[i, j] = matrix[i, maxPosition];
                matrix[i, maxPosition] = temporarray;
            }

        }
    }
}


Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] array = size.Split(",");
int[,] massive = new int[Convert.ToInt32(array[0]), Convert.ToInt32(array[1])];

FillMatrix(massive);
PrintMatrix(massive);
Console.WriteLine();
Console.WriteLine("Сортировать строки по возрастанию (<) или убыванию (>)?");
char sort = Convert.ToChar(Console.ReadLine());
SortMatrixRows(massive, sort);
PrintMatrix(massive);

