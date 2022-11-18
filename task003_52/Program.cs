//Задайте двумерный массив  из целых чисел. Найлите среднее 
//арифметическое элементов в каждом столбце.

Console.Write("Enter M(number of columns): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  N(number of rows): ");
int n = Convert.ToInt32(Console.ReadLine());

Random r = new Random();

int[,] arr = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; ++j)
    {
        arr[i, j] = r.Next(0, 11); 
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}


Console.WriteLine("Columns mean:");
float[] average_by_cols = new float[n];

for (int j = 0; j < n; ++j) // итерируемся по столбцам
{
    long current_sum = 0;
    for (int i = 0; i < m; ++i) // итерируемся по строкам
    {
        current_sum += arr[i, j];
    }
    average_by_cols[j] = (float)current_sum / m;
    Console.Write(string.Format("{0:F2}", average_by_cols[j]) + "\t");
}
