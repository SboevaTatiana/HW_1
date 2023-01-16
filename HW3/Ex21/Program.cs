// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве...

Console.Write("введите координату x1 - ");
int num_x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y1 - ");
int num_y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату z1 - ");
int num_z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату x2 - ");
int num_x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y2 - ");
int num_y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату z2 - ");
int num_z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(num_x1-num_x2, 2) + Math.Pow(num_y1-num_y2, 2) + Math.Pow(num_z1-num_z2, 2));

Console.WriteLine("Расстояние между точками = " + d);
