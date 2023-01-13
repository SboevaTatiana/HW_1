// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 5) && (number < 8))
{
  Console.WriteLine("Выходной");
}
 else if ((number > 0) && (number < 6))
      {
        Console.WriteLine("Будни");
      }
       else
      {
        Console.WriteLine("Введено некорректное значение");
      }