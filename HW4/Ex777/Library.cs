public static class Library
{
  // 1. Ввод N
  // int <- (string)

  public static int Input()
  {
    Console.Write("Введите число - длину будущего массива: ");
    return Convert.ToInt32(Console.ReadLine());
  }

  // 2. Создание массива
  // int[] <- (int)

  public static int[] CreateArray(int Number)
  {
    int[] array = new int[Number];
    return array;
  }

  // 3. Заполнение массива 0 и 1
  // void <- (int[])

  public static void FillArray(int[] binNumber)
  {
    int count = binNumber.Length;
    for (int i = 1; i < count; i++)
    {
      binNumber[i] = Random.Shared.Next(2);
    }
    binNumber[0] = 1;
  }

  // 4. Печать массива
  // string <- (int[])

  public static string PrintArray(int[] Numbers)
  {
    string output = String.Empty;
    int size = Numbers.Length;

    for (int i = 0; i < size; i++)
    {
      output = output + $"{Numbers[i]}" + " ";
    }
    return output;
  }

  // 5. Конвертация из 2-ого в 10-ое
  // int <- (int[])

  public static int ConvertDec(int[] arrBin)
  {
    int count = arrBin.Length;
    int exponent = arrBin.Length - 1;
    int result = 0;
    for (int i = 0; i < arrBin.Length; i++)
    {
      if (arrBin[i] == 1)
      {
        result += Convert.ToInt32(Math.Pow(2, exponent));
      }
      exponent--;
    }
    return result;
  }

  // 6. 10110100 >> 180
  // string <- (int[] , int)

  public static string BackPrint(int[] bin, int dec)
  {
    return $"{String.Join(" ", bin)} >> {dec}";
  }

}