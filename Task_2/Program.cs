// Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки:  ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:  ");
int column = Convert.ToInt32(Console.ReadLine());
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
void SearchElement(int[,] array)
{
  if (line <= 0 && column <= 0 || line <= 0 || column <= 0)
    Console.WriteLine($"Введено неверное значение");
  else if (line <= array.GetLength(0) && column <= array.GetLength(1))
    Console.WriteLine($"Значение элемента на данной позиции = {array[line - 1, column - 1]}");
  else Console.WriteLine($"Такого элемента в массиве нет");
}
Console.WriteLine();
int[,] array = CreateMtrixRndInt(3, 4, -99, 99);
PrintMatrix(array);
Console.WriteLine();
SearchElement(array);