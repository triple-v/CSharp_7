// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
  double[,] matrix = new double[row, col];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.NextDouble() * (max - min) + min;
    }
  }
  return matrix;
}
void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{Math.Round(matrix[i, j], 2),6} ");

    }
    Console.WriteLine();
  }
}
double[,] array = CreateMtrixRndInt(3, 4, -10, 10);
PrintMatrix(array);