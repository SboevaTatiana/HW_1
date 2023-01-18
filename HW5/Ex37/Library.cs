public static class Library
{
  // 1. Ввод N

  public static int Input()
  {
    Console.Write("Введите число - длину будущего массива: ");
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
    int count = number.Length;
    for (int i = 0; i < count; i++)
    {
      number[i] = Random.Shared.Next(10);
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

  public static void Proizv(int[] array)
  {
    int j = array.Length - 1;
    Console.WriteLine("Произведение пар чисел: ");
    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
      array[i] = (array[i] * array[j]);
      Console.Write(array[i] + " ");
      j--;
    }
  }


}