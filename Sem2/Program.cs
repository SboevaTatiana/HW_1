// Задача 10:  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.




int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}



// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}



// Задача 13. Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
string? number = Console.ReadLine();
if (number is not null)
{
  if (number.Length < 3)
  {
    Console.WriteLine("Третьей цифры нет");
  }
  else
  {
    Console.WriteLine(number[2]);
  }
}

/*

////////////////////////////
// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/


// Задача 27. Написать программу, которая принимает на вход число и выдает сумму цифр в числе.
System.Console.WriteLine("Задача 27. Написать программу, которая принимает на вход число и выдает сумму цифр в числе");
System.Console.Write("Введите число: ");
int F = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр в числе {F} равна {GetNumberSum(F)}");

// ---------------Методы-----------------
int GetNumberSum (int nmb)
{
    int sum = 0;
    for (int n = nmb; n > 0; n = n / 10)
    {
        sum = sum + n % 10;
    }
    return sum;
}



// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().Next(0, 2);
  Console.Write(arr[i] + " ");
}
*/