int[,] MultiDimensionalArray()
{
    int[,] Array = new int[new Random().Next(8), new Random().Next(8)];
    return Array;
}

int[,] RandomFillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }

}

int ComputeMainDiagonal(int[,] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i == j) sum = sum + Array[i,j];
        }
    }
    return sum;
}


int[,] Array = RandomFillArray(MultiDimensionalArray());
PrintArray(Array);

int sum = ComputeMainDiagonal(Array);
Console.WriteLine(sum);