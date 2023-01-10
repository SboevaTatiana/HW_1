// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int n = 8;
int[] array = new int[n + 1];
int index = 1;

while (index < n + 1)
{
  if (index % 2 == 0)
  {
    array[index] = index;
    Console.WriteLine(array[index]);
  }
  index++;
}
