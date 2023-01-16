public static class Library
{
  // 1. Ввод N

  public static int Input()
  {
    Console.Write("Введите число ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
  }

  // 2. Подсчет суммы цифр в числе
  public static int Sum(int numb)
  {
    int sum = 0;
    while (numb != 0)
    {
      sum = sum + numb % 10;
      numb = numb / 10;
    }
    return sum;
  }

}