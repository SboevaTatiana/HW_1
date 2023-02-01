public static class Library
{

  // Заполнение массива 

  public static void FillArrayRandomNumbers(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = new Random().Next(0, 10);
      }
    }
  }

  // Печать массива

  public static void PrintArray(int[,] array)
  {

    for (int i = 0; i < array.GetLength(0); i++)
    {
      Console.Write("[ ");
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write(array[i, j] + " ");
      }
      Console.Write("]");
      Console.WriteLine("");
    }
  }


}

