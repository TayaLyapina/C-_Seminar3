/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int xa = ReadInt("Введите координату точки А по x: ");
int ya = ReadInt("Введите координату точки A по y: ");
int za = ReadInt("Введите координату точки A по z: ");

int xb = ReadInt("Введите координату точки B по x: ");
int yb = ReadInt("Введите координату точки B по y: ");
int zb = ReadInt("Введите координату точки B по z: ");

int x = xa - xb ;
int y = ya - yb ;
int z = za - zb;

double distance = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine("Расстояние между точкми А и В = " + distance);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}