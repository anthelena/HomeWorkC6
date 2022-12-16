// Задача 47. Задайте двумерный массив (вручную) размером m×n, 
// заполненный вещественными числами. m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Enter m and n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m, n];
 Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(-99,99) / 10.0;
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }