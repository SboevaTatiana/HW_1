// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using static Library;

Console.WriteLine("Введите количество строк (m)");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n)");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

