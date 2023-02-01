public static class Library
{

  // Заполнение массива 

  public static void FillArrayRandomNumbers(double[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
      }
    }
  }

  // Печать массива

  public static void PrintArray(double[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write("[ ");
        Console.Write(array[i, j] + " ");
        Console.Write("]");
      }
      Console.WriteLine("");
    }
  }


}

