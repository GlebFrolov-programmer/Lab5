using triangle;

namespace triangleColor
{
    public class TriangleColor : Triangle
    {
        private string color; // цвет фигуры
        public TriangleColor(string name, string color, double a, double b, double c)
            : base(name,a,b,c)
        {
            Color = color;
        }
        public string Color
        {
            get => color;
            set => color = (value == null ? string.Empty : value);
        }
        public override double Area2 => base.Area2;
        public override double Area() => base.Area();
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"; Цвет фигуры: {Color}");
        }
    }
}