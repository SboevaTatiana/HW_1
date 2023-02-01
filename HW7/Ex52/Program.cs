// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using static Library;

Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
  double averageVal = 0;
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    averageVal = (averageVal + numbers[i, j]);
  }
  averageVal = Math.Round(averageVal / m, 1) ;
  Console.Write(averageVal + "; ");
}
