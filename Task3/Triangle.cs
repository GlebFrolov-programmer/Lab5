using figure;

namespace triangle
{
    public class Triangle : Figure
    {
        private double a, b, c; // стороны треугольника
        public Triangle(string name, double a, double b, double c) : base(name)
        {
            SetABC(a, b, c);
        }
        public override double Area2
        {
            get
            {
                double p = 0.5*(a + b + c);
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public override double Area()
        {
            return Area2;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"; Стороны фигуры: a = {a}, b = {b}, c = {c}; Площадь = {Area()}");
        }
        public void SetABC(double a, double b, double c)
        {
            this.a = (a < 0 ? 0 : a);
            this.b = (b < 0 ? 0 : b);
            this.c = (c < 0 ? 0 : c);
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }
    }
}