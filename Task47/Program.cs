Console.WriteLine("Задайте размерность двумерного массива m x n: ");
Console.Write(" Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m ,n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix [i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", matrix[i, j]);
    }
    Console.WriteLine();
}

