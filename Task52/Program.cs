Console.Write("Введите m = ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(-100, 100);
        Console.Write(arr[i, j] + " ");
    }
Console.WriteLine();
}
Console.WriteLine(arr.GetLength(0));
Console.WriteLine();
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
