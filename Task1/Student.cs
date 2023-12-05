using person;

namespace student
{
    class Student : Person 
    {
        Random rnd = new Random();
        private int course;
        public int Course
        {
            get { return course; }
            set { if (value < 0) value = 0; course = value; }
        }
        public Student(string name, string surname, int age, int course) : base(name, surname, age)
        {
            this.Status = statusArray[rnd.Next(0,3)];
            this.Course = course;
        }
        string[] statusArray = new string[] 
        {
            "Бакалавр",
            "Магистр",
            "Аспирант"
        };
        private static Student[] studentArray = new Student[5]
        {
            new Student("Игорь", "Ященко", 18, 1),
            new Student("Артём", "Измайлов", 20, 3),
            new Student("Александр", "Мольков", 21, 4),
            new Student("Егор", "Глотов", 19, 2),
            new Student("Арина", "Коннова", 19, 1),
        };


        public override void Print()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nStatus: {Status}");
        }
        public override string ToString()
        {
            return $"{Name} {Surname}, {Age}, {Status}";
        }
        public virtual bool Equals(Student other)
        {
            return this.Name == other.Name && this.Surname == other.Surname && this.Age == other.Age && this.Status == other.Status;
        }
        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = 30*hash + Surname.GetHashCode();
            hash = 30*hash + Age.GetHashCode();
            return hash;
        }

        public override Student RandomPerson()
        {
            return studentArray[rnd.Next(0, 5)];
        }

        public override Student Clone()
        {
            Student s = new Student(this.Name, this.Surname, this.Age, this.Course);
            s.Status = this.Status;
            return s;
        }
    }
}