
Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());

void NumberCounter(int number)
{
  if (number < 0)
  {
    Console.Write($"{number} - не натуральное число");
    return;
  }
  if (number == 0)
    return;

  Console.Write("{0,3}", number);
  NumberCounter(--number);
}

NumberCounter(number);


