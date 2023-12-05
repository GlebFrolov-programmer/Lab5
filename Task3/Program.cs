using triangle;
using triangleColor;

Console.Write("Test class triangle:");
Triangle triangle = new("Треугольник", 6, 8, 10);
triangle.Print();
Console.WriteLine();
Console.Write("Test class triangleColor:");
TriangleColor triangleColor = new("Треугольник", "Синий", 10, 12, 16);
triangleColor.Print();