/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] IntersectionPoint(double[] array)
{
    double[] intersectionPoint = new double[2];
    intersectionPoint[0] = Math.Round(((array[1] - array[3]) / (array[2] - array[0])), 2);
    intersectionPoint[1] = Math.Round((array[0] * intersectionPoint[0] + array[1]), 2);
    return intersectionPoint;
}


void PrintCoordinates(double[] array)
{
    Console.WriteLine($"({array[0]}, {array[1]})");
}

Console.WriteLine("Введите координаты прямых через пробел в виде: k1, b1, k2 и b2: ");

double[] coordinates = Console.ReadLine()!.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
double[] intersectionPointUser = IntersectionPoint(coordinates);
 
Console.Write($"Точка пересечения двух прямых: ");
PrintCoordinates(intersectionPointUser);