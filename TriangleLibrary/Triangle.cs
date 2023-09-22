using System;

namespace TriangleLibrary
{
    public class Triangle
    {
        public static string DetermineTriangleType(double a, double b, double c)
        {
            // Проверка корректности длин сторон
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Неверные длины сторон";
            }

            // Проверка на существование треугольника по неравенству треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "Треугольник не существует";
            }

            // Нахождение квадратов
            double aSquare = a * a;
            double bSquare = b * b;
            double cSquare = c * c;

            // Определение вида треугольника
            if (aSquare + bSquare == cSquare || aSquare + cSquare == bSquare || bSquare + cSquare == aSquare)
            {
                return "Прямоугольный треугольник";
            }
            else if (aSquare + bSquare < cSquare || aSquare + cSquare < bSquare || bSquare + cSquare < aSquare)
            {
                return "Тупоугольный треугольник";
            }
            else
            {
                return "Остроугольный треугольник";
            }
        }
    }
}