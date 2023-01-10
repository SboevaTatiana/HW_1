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


/*int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
  if (i % 2 != 1)
  {
    Console.Write(i + ", ");
    not = false;
  }
  i++;
}

if (not)
{
  Console.WriteLine("Нет чётных чисел!");
}
*/