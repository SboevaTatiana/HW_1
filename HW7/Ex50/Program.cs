// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static Library;

Console.WriteLine("Введите номер строки (m)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца (n)");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[5, 5];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
  Console.WriteLine($"Элемента с позицией [{n},{m}] в данном массиве нет.");
}
else
{
  Console.WriteLine($"Значение элемента с позицией [{n},{m}]  равно {numbers[n - 1, m - 1]}");
}
