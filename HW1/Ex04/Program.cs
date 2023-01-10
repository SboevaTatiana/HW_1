// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа:");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int a3 = Convert.ToInt32(Console.ReadLine());

int max = a1;

if (a2 > max)
{
  max = a2;
}

if (a3 > max)
{
  max = a3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);