// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void RowWithSmallestSumOfElements(int[,] matrix)
{
    int[] mass = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        mass[i] = sum;
        Console.WriteLine($"Сумма элементов в строке {i+1} = {mass[i]}");
    }
    int minPosition = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < mass[minPosition])
        {
            minPosition = i;
        }    
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов находится в строке - {minPosition + 1}");
}


Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] array = size.Split(",");
int[,] massive = new int[Convert.ToInt32(array[0]), Convert.ToInt32(array[1])];

FillMatrix(massive);
PrintMatrix(massive);
Console.WriteLine();
RowWithSmallestSumOfElements(massive);
