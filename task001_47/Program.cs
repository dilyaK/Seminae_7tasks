Console.Write("Enter number of M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of N: ");
int n = Convert.ToInt32(Console.ReadLine());
        
Random r = new Random();
        
float[,] arr = new float[m, n];

for (int i = 0; i < m; ++i)
{
	for (int j = 0; j < n; ++j)
        {
                arr[i, j] = (float)r.NextDouble() * 20 - 10;
        }
}

for (int i = 0; i < m; ++i)
{
	for (int j = 0; j < n; ++j)
        {
                Console.Write(string.Format("{0,7:F3}", arr[i, j]) + "\t"); 
        }
        Console.WriteLine();
}
