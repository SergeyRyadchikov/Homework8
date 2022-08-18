// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void FillMatrixInSpiral(int[,] arr)
{
    int finalPosition = arr.GetLength(0);
    int startPosition = 0;
    int start = 1;
    int i = 0;
    int j = 0;
    while (start <= arr.Length)
    {
        while (j < finalPosition)
        {
            arr[i, j] = start;
            start++;
            j++;
        }
        i++;
        while (i < finalPosition)
        {
            arr[i, j-1] = start;
            start++;
            i++;
        }
        j--;
        while (j > startPosition)
        {
            arr[i-1, j-1] = start;
            start++;
            j--;
        }
        finalPosition--;
        startPosition++;
        i = i - 1;
        while (i > startPosition)
        {
            arr[i-1, j] = start;
            start++;
            i--;
        }
        j++;
    }
}

void PrintMatrix(int[,] coll)
{
    int lines = coll.GetLength(0);
    int columns = coll.Length / lines;
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(coll[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




Console.Write("Введите размерность матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
FillMatrixInSpiral(array);
PrintMatrix(array);
