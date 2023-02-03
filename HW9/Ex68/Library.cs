public static class Library
{

  // Ввод числа

  public static int InputNumbers(string input)
  {
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
  }

  // Подсчет функции Аккермана

  public static int Ack(int m, int n)
  {
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
  }


}

