public static class Library
{
  // 1. Ввод N

  public static int Input()
  {
    Console.Write("Сколько чисел хотите ввести? ");
    return Convert.ToInt32(Console.ReadLine());
  }

  // 2. Создание массива

  public static int[] CreateArray(int number)
  {
    int[] array = new int[number];
    return array;
  }

  // 3. Заполнение массива 

  public static void FillArray(int[] number)
  {
    Console.WriteLine("Вводите ");
    int count = number.Length;
    for (int i = 0; i < count; i++)
    {
      number[i] = Convert.ToInt32(Console.ReadLine());
    }
  }

  // 4. Печать массива

  public static void PrintArray(int[] numbers)
  {
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.Write(numbers[i] + " ");
    }
  }

  // 5. Произведение пар чисел

  public static int howManyNumbers(int[] array)
  {
    int result = 0;
    Console.WriteLine("Количество чисел больше нуля: ");
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] > 0)
      {
        result++;
      }

    }
    return result;
  }


}

