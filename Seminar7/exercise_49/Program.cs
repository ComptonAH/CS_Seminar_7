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

int[,] ModiffiedArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) Array[i, j] = Array[i, j] * Array[i, j];
        }
    }
    return Array;
}

int[,] Array = RandomFillArray(MultiDimensionalArray());
PrintArray(Array);

int[,] NewArray = ModiffiedArray(Array);
Console.WriteLine();
PrintArray(Array);