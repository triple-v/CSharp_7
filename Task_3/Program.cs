// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

System.Console.WriteLine();
int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
  int[,] matrix = new int[row, col];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
  }
  return matrix;
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
      else Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine();
  }
}
void MeanArithmeticColumn(int[,] array)
{
  Console.WriteLine($"Среднее арифметическое элементов столбца массива:");
  Console.WriteLine();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    double meanArithmetic = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      meanArithmetic = meanArithmetic + array[j, i];
    }
    meanArithmetic = Math.Round(meanArithmetic / array.GetLength(1), 1);
    Console.WriteLine($" {i + 1}  = {meanArithmetic}");
  }
  Console.WriteLine();
}
int[,] array = CreateMtrixRndInt(5, 5, 1, 10);
PrintMatrix(array);
Console.WriteLine();
MeanArithmeticColumn(array);