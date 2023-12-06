namespace figure
{
    public abstract class Figure
    {
        private string name; // название фигуры
        public Figure(string name)
        {
            Name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value == null? string.Empty : value);
            }
        }
        public abstract double Area2 { get;}
        public abstract double Area();
        public virtual void Print()
        {
            Console.WriteLine($"Название фигуры: {Name}");
        }
    }
}