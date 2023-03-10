// Задача 777:
// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное
// 1. Ввод N
// int <- (string)
// 2. Создание массива
// int[] <- (int)
// 3. Заполнение массива 0 и 1
// void <- (int[])
// 4. Печать массива
// string <- (int[])
// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])
// 6. 10110100 >> 180
// string <- (int[] , int)
// string GoodPrint(int[] bin, int dec)
// {
// return $"{String.Join("", bin)} >> {dec}";
// }
// Console.WriteLine(GoodPrint(new int[] { 1, 0, 1, 1, 1, 1, 0 }, 56));

using static Library;

int number = Input();
int[] array = CreateArray(number);
FillArray(array);
int result = ConvertDec(array);
string binPrint = PrintArray(array);
Console.WriteLine(binPrint);
Console.WriteLine(BackPrint(array, result));