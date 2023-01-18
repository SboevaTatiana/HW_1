// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА


using static Library;

int number = Input();
int[] array = CreateArray(number);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Proizv(array);