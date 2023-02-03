public static class Library
{

  // Ввод числа

  public static int InputNumbers(string input)
  {
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
  }

  // Подсчет суммы натуральных чисел от M до N

  public static void PrintSumm(int numberM, int numberN, int summ)
{
  summ += numberN;
  if (numberN <= numberM)
  {
    Console.Write($"Сумма натуральных элементов в промежутке от M до N = {summ} ");
    return;
  }
  PrintSumm(numberM, numberN - 1, summ);
}


}

