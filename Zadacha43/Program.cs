/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.Clear();
void FindPoint(double b1, double k1, double b2, double k2)
{
   
    double pointy = (b2 - k2 / k1 * b1) / (1 - k2 / k1);

    double pointx = (pointy - b1) / k1;

    Console.WriteLine($"Точка пересечения двух прямых: ({Math.Round(pointx, 1)}; {Math.Round(pointy, 1)})");
}
Console.WriteLine("Введите число: b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число: k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число: b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число: k2");
double k2 = Convert.ToDouble(Console.ReadLine());

FindPoint(b1,k1,b2,k2);

