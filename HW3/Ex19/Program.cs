// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number < 10000) && (number > 99999))
{
  Console.WriteLine("Введено не пятизначное число");
}

void Check(int val1)
{
  int val2 = 0;
  int t = val1;
  while (val1 != 0)
  {
    int o = val1 % 10;
    val1 = val1 / 10;
    val2 = val2 * 10 + o;
  }

  if (t == val2)
  {
    Console.WriteLine("Число является палиндромом");
  }
  else
  {
    Console.WriteLine("Введенное число не палиндром");
  }
}

Check(number);