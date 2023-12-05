using person;

namespace teacher
{
    class Teacher : Person 
    {
        Random rnd = new Random();
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {
            this.Status = statusArray[rnd.Next(0,3)];
        }
        string[] statusArray = new string[] 
        {
            "Мат анализ",
            "АиГ",
            "Дискретная математика"
        };
        private static Teacher[] teacherArray = new Teacher[5]
        {
            new Teacher("Татьяна", "Смирнова", 35),
            new Teacher("Алексей", "Шорохов", 39),
            new Teacher("Сегрей", "Веселов", 55),
            new Teacher("Дмитрий", "Чирков", 28),
            new Teacher("Ирина", "Шашкова", 42),
        };


        public override void Print()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nStatus: {Status}");
        }
        public override string ToString()
        {
            return $"{Name} {Surname}, {Age}, {Status}";
        }
        public virtual bool Equals(Teacher other)
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

        public override Teacher RandomPerson()
        {
            return teacherArray[rnd.Next(0, 5)];
        }

        public override Teacher Clone()
        {
            Teacher t = new Teacher(this.Name, this.Surname, this.Age);
            t.Status = this.Status;
            return t;
        }
    }
}