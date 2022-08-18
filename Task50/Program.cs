Console.Write("Ввидите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите n: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillRandomDoubleArray(int lines = 3, int columns = 4, int leftRange = -10, int rethRange = 10)
{
    int[,] randomArray = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = rand.Next(leftRange, rethRange + 1);
        }
    }
    return randomArray;
}

int[,] array = FillRandomDoubleArray();
if (m >= array.GetLength(0) || n >= array.GetLength(1))
{
    Console.Write(" Элемента нет ");
}
else
{
    PrintMatrix(array);
    Console.Write("Заданный элемент массива = " + array[m, n]);
}

