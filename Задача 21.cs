// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("введите 6 чисел!");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());

int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Sqrt(Math.Pow(Ax - Bx, 2)) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2);
Console.WriteLine("ответ " + distanse);