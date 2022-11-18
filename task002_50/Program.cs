//Напишите программу, которая принимает на вход позиции элемента 
//в двумерном массиве и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
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
                Console.Write(string.Format("{0,7:F3}", arr[i, j]) + "\t"); // {номер аргумента,количество позиций на аргумент:<Спецификатор><Число знаков после запятой>}
        }
        Console.WriteLine();
}

Console.Write("Enter the row number: ");
int row_pos = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number: ");
int col_pos = Convert.ToInt32(Console.ReadLine());
        
if (row_pos >= 0 && row_pos < m && col_pos >= 0 && col_pos < n)
{
        Console.WriteLine("Number at this positon = " + arr[row_pos, col_pos]);
}
else
{
        Console.WriteLine("No such number in the array");
}
