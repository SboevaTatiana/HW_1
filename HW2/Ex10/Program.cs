// Задача 10:  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000))
{
    number = number % 100 / 10;
    Console.WriteLine("Вторая цифра этого числа: " + number);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}
