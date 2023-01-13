// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
string? number = Console.ReadLine();
if (number.Length < 3)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  Console.WriteLine(number[2]);
}
